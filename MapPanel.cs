using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQASkeletronPlus
{
    /// <summary>
    /// A graphical map panel that represents buildings in the AQA simulation.
    /// </summary>
    public class MapPanel : PictureBox
    {
        //User set flags.
        public bool DrawTracers = false;

        //Map width and height.
        private int mapWidth = -1;
        private int mapHeight = -1;

        //List of households/outlets to draw.
        private List<Vector2> households = new List<Vector2>();
        private List<Vector2> outlets = new List<Vector2>();
        private List<Tuple<Vector2, Vector2>> tracers = new List<Tuple<Vector2, Vector2>>();

        //Brushes to use for the base, and outlets/houses.
        private Color baseColour = Color.White;
        private Brush outletBrush = Brushes.Green;
        private Brush householdBrush = Brushes.MediumPurple;
        private Brush connectingLineBrush = Brushes.Red;

        //Constructor which hooks the paint event.
        public MapPanel() : base()
        {
            base.Paint += PaintMap;
        }

        //Paints the map to the image, and scales correctly.
        private void PaintMap(object sender, PaintEventArgs e)
        {
            //Get the current map scale.
            int xCellSize = Convert.ToInt32(base.Width / mapWidth);
            int yCellSize = Convert.ToInt32(base.Height / mapHeight);

            //Paint the entire canvas in the base brush.
            e.Graphics.Clear(baseColour);

            //Paint individual outlets onto the canvas.
            foreach (var outlet in outlets)
            {
                Vector2 outletPixelPos = new Vector2(outlet.x * xCellSize, outlet.y * yCellSize); //Pixel position of outlet on canvas.
                e.Graphics.FillRectangle(outletBrush, new Rectangle(outletPixelPos.x, outletPixelPos.y, xCellSize, yCellSize));
            }

            //Paint individual houses onto canvas.
            foreach (var house in households)
            {
                Vector2 housePixelPos = new Vector2(house.x * xCellSize, house.y * yCellSize); //Pixel position of the house on canvas.
                e.Graphics.FillRectangle(householdBrush, new Rectangle(house.x, house.y, xCellSize, yCellSize));
            }
            
            //Should tracers be drawn?
            if (DrawTracers)
            {
                foreach (var tracer in tracers)
                {
                    //Draw a line from the center of the house cell to the center of the outlet cell.
                    Vector2 startingCenter = GetPixelCenterOfCell(tracer.Item1);
                    Vector2 endCenter = GetPixelCenterOfCell(tracer.Item2);
                    e.Graphics.DrawLine(new Pen(connectingLineBrush), startingCenter.x, startingCenter.y, endCenter.x, endCenter.y);
                }
            }
        }
        
        /// <summary>
        /// Sets the size of the map for this panel.
        /// </summary>
        public void SetSize(int x, int y)
        {
            if (base.Width / x < 1 || base.Height / y < 1) { throw new Exception("Panel is too small to display this map."); }
            if (x < 1 || y < 1) { throw new Exception("Invalid map size, must be >=1x1."); }
            mapWidth = x;
            mapHeight = y;
        }

        /// <summary>
        /// Clears all data on the map.
        /// </summary>
        public void Clear()
        {
            outlets = new List<Vector2>();
            households = new List<Vector2>();
            tracers = new List<Tuple<Vector2, Vector2>>();
        }

        /// <summary>
        /// Sets a household to draw on the grid.
        /// </summary>
        public void AddHousehold(int x, int y)
        {
            VerifyCoordinates(x, y);

            //Don't add duplicate houses.
            foreach (Vector2 house in households)
            {
                if (x == house.x && y == house.y) { return; }
            }

            households.Add(new Vector2(x, y));
        }

        /// <summary>
        /// Sets an outlet to draw on the grid.
        /// </summary>
        public void AddOutlet(int x, int y)
        {
            VerifyCoordinates(x, y);

            //Don't add duplicate outlets.
            foreach (Vector2 outlet in outlets)
            {
                if (x == outlet.x && y == outlet.y) { return; }
            }

            outlets.Add(new Vector2(x, y));
        }

        /// <summary>
        /// Adds a list of buildings all at once, instead of adding one at a time.
        /// </summary>
        public void AddBuildings(List<Building> list)
        {
            foreach (var building in list)
            {
                if (building.Type == BuildingType.Household)
                {
                    AddHousehold(building.Position.x, building.Position.y);
                }
                else if (building.Type == BuildingType.Outlet)
                {
                    AddOutlet(building.Position.x, building.Position.y);
                }
                else
                {
                    throw new Exception("Unrecognized building type to add to map.");
                }
            }
        }

        //Verifies coordinates, and throws an error if failes.
        private void VerifyCoordinates(int x, int y)
        {
            if (x < 0 || y < 0) { throw new Exception("Invalid map coordinate, x or y cannot be negative."); }
            if (x >= mapWidth || y >= mapHeight) { throw new Exception("Invalid map coordinate, outside map bounds (too large)"); }
        }

        /// <summary>
        /// Sets the households that ate out and visited a company for this day.
        /// </summary>
        public void SetTracers(List<Tuple<Vector2, Vector2>> tracers_)
        {
            tracers = tracers_;
        }

        /// <summary>
        /// Returns the pixel coordinates for the center of a cell given a vector coordinate.
        /// </summary>
        public Vector2 GetPixelCenterOfCell(Vector2 position)
        {
            //Get the current map scale.
            int xCellSize = Convert.ToInt32(base.Width / mapWidth);
            int yCellSize = Convert.ToInt32(base.Height / mapHeight);

            //Get the top left.
            int xTopLeft = position.x * xCellSize;
            int yTopLeft = position.y * yCellSize;

            //Shift to the middle.
            int xMiddle = xTopLeft + (xCellSize / 2);
            int yMiddle = yTopLeft + (yCellSize / 2);

            return new Vector2(xMiddle, yMiddle);
        }
    }

    /// <summary>
    /// Map's Vector2 class.
    /// </summary>
    public class Vector2
    {
        public Vector2(int x_, int y_) { x = x_; y = y_; }
        public int x, y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        /// <summary>
        /// Calculates the distance from this Vector2 instance to another Vector2.
        /// </summary>
        public double DistanceTo(Vector2 other)
        {
            //Calculate differences.
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;

            //Modulus using pythagoras.
            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }
    }

    /// <summary>
    /// Represents a single building w/ type on the grid.
    /// </summary>
    public struct Building
    {
        public Vector2 Position;
        public BuildingType Type;
    }

    /// <summary>
    /// The different available building types on the grid.
    /// </summary>
    public enum BuildingType
    {
        Outlet,
        Household
    }
}
