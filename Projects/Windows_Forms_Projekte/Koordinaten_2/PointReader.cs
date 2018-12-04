using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PointCoords
{
    class PointReader
    {   
        // Dateioperationen für die Klasse Point
        private string path;

        // Datenstruktur ArrayList
        public List<Point> PointList = new List<Point>();
         
        //Konstruktor
        public PointReader(){}

        //Methoden
        public void AddPoint(double x, double y)
        {
            Point p= new Point();  
            p.Xcoord = x; p.Ycoord = y;
            PointList.Add(p);
         }

        public void WriteToFile(string path)
        {   // Write Textfile
            this.path = path;
            StreamWriter sw = new StreamWriter(path);
            // appends points to file
            foreach(Point p in PointList)  {sw.WriteLine("{0};{1}", p.Xcoord, p.Ycoord); }
            sw.Close();
        }

        public void WriteToFileBin(string path)
        {   // Write binary file
            this.path = path;
            FileStream fileStr = new FileStream(path, FileMode.Create);
            BinaryWriter binWriter = new BinaryWriter(fileStr);
            // appends points to file
            binWriter.Write(PointList.Count);    //int  
            foreach (Point p in PointList) 
            { 
                binWriter.Write(p.Xcoord);
                binWriter.Write(p.Ycoord); 
            }
            binWriter.Close(); fileStr.Close();
        }

        public List<Point> GetFromFile(string path)
        {    // Read Textfile
            this.path = path;
            string zeile="";
            Point p = new Point();
            StreamReader sr = new StreamReader(path);
            PointList.Clear();

            while ((zeile = sr.ReadLine()) != null)
            {
                string[] coords = zeile.Split(new char[1] { ';' });
                p.Xcoord = double.Parse(coords[0]);
                p.Ycoord = double.Parse(coords[1]);
                PointList.Add(p);
            }
            sr.Close();
            return PointList;
        }

        public List<Point> GetFromFileBin(string path)
        {   // Read binary file
            this.path = path;
            Point p=new Point();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
          
            PointList.Clear();

            int anzahl = br.ReadInt32();
            for (int i = 0; i < anzahl; i++)
            {
                p.Xcoord = br.ReadDouble();
                p.Ycoord = br.ReadDouble();
                PointList.Add(p);
            }
            br.Close(); fs.Close();
            return PointList;
        }

        public Point GetPoint(int pointNo)
        { // 1...Anzahl
            if (pointNo <= PointList.Count && pointNo > 0)
            {
                return (Point)PointList[pointNo-1];
            }
            else
            {
                throw new IndexOutOfRangeException("Illegal Pointnumber");
            }
        }

        public Point GetPointBin(int pointNo)
        {   
            Point savedPoint = new Point();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            fs.Seek(0, SeekOrigin.Begin);
            int pos  = 4 + (pointNo - 1) * 16;
            // hat der Anwender eine gültige Position angegeben?
            if (pointNo > br.ReadInt32() || pointNo <= 0)
            {
                br.Close();
                string message = "Unter der angegebenen Position ist";
                message += " kein \nPoint-Objekt gespeichert.";
                throw new IndexOutOfRangeException(message);
            }
            else
            {
                // den Zeiger positionieren
                fs.Seek(pos, SeekOrigin.Begin);
                // Daten des gewünschten Points einlesen
                savedPoint.Xcoord = br.ReadDouble();
                savedPoint.Ycoord = br.ReadDouble();
                br.Close(); fs.Close();
                return savedPoint;
            } 
        }

    }//class
}//ns
