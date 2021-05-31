using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDrawCore
{
    public class FiguresData
    {
        public string Name;
        public Dictionary<string, int> Data;

        public override string ToString()
        {
            return Name;
        }
    }

    static public class FigureFab
    {
        public static Figure Make(FiguresData figData)
        {
            Figure fig = null;

            switch (figData.Name)
            {
                case "Line":
                    fig = new Line(figData.Data["X1"], figData.Data["Y2"], figData.Data["X2"], figData.Data["Y2"]);
                    break;
                case "Circle":
                    fig = new Circle(figData.Data["X"], figData.Data["Y"], figData.Data["Radius"]);
                    break;
            }

            return fig;
        }

        public static List<FiguresData> InitFiguresData()
        {
            var figuresData = new List<FiguresData>();

            figuresData.Add(new FiguresData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 },
                    { "Radius", 100 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 100 },
                    { "Y2", 100 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Rectangle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Height", 100 },
                    { "Weight", 100 }
                }
            });

            return figuresData;
        }
    }
}