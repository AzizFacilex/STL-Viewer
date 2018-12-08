using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StlReader
{
    public class Normal_Vectors
    {
        public List<Normal_vector> Vectors;

        public Normal_Vectors()
        {
            Vectors = new List<Normal_vector>();
        }

        public bool IS_ASCII(string s)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(s);
            string h = file.ReadLine();
            string b = "";
            for (int i = 0; i < 5; i++)
                b = b + h[i];
            if (b == "solid")
            {
                file.Close();
                return true;
            }
            file.Close();
            return false;
        }

        private List<string> getLineStrings(string[] input)
        {
            List<string> mm_ret = new List<string>();
            foreach (string mm_val in input)
            {
                if (mm_val != "") mm_ret.Add(mm_val);
            }
            return mm_ret;
        }

        
        public void ASCII_Reader(Normal_Vectors normal_vectors, Pointlist list, Linelist L, Surfacelist lists,
            string Path)
        {
            Point[] T = new Point[3];

            CultureInfo mm_akt = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");

            string[] mm_lines = File.ReadAllLines(Path);
            int cur = 0; 
            foreach (string Line in mm_lines)
            {
                Line.Trim();
                List<string> mm_parts = getLineStrings(Line.Split(' '));
                int ct = mm_parts.Count;
                if (string.Compare("facet", mm_parts[0], StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    Normal_vector normal = new Normal_vector(float.Parse(mm_parts[2]), float.Parse(mm_parts[3]), float.Parse(mm_parts[4]));
                    normal_vectors.Vectors.Add(normal);
                }
                else if (string.Compare("vertex", mm_parts[0], StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    T[cur] = new Point(float.Parse(mm_parts[1]), float.Parse(mm_parts[2]), float.Parse(mm_parts[3]));
                    cur++;
                }
                if (cur == 3)
                {
                    line lin = new line();
                    lin.point_start = T[0];
                    lin.point_end = T[1];
                    L.add(lin);
                    line lim = new line();
                    lim.point_start = T[0];
                    lim.point_end = T[2];
                    L.add(lim);
                    line lil = new line();
                    lil.point_start = T[1];
                    lil.point_end = T[2];
                    L.add(lil);
                    //add the Line to the Pointlist
                    list.add(lin);
                    list.add(lim);
                    list.add(lil);
                    //-----------------------------------------
                    Surface s = new Surface();
                    s.line1 = lin;
                    s.line2 = lim;
                    s.line3 = lil;
                    //add the surface to the list from lines
                    L.add(s);
                    //add the surface to the list from Surfaces
                    lists.Surfaceliste.Add(s);
                    cur = 0;
                }
            }
            Thread.CurrentThread.CurrentCulture = mm_akt;

            ////Line = File_text.ReadLine().Trim().Replace(" ", "");
            //while (Line != "endsolid")
            //        {
            //            //Line = File_text.ReadLine().Trim().Replace(" ", ""); //facetnormal

            //            if (Line == "endsolid")
            //            {
            //                break;
            //            }

            //    // FaceNormal  
            //    if (Line[11] == '-') // Negative x

            //    {
            //        v.x = float.Parse(Line.Substring(11, 13)); //x
            //        if (Line[24] == '-')// Negative x and Negative y
            //        {
            //            v.y = float.Parse(Line.Substring(24, 13)); //y
            //            if(Line[37]=='-') //Negative x,y,z
            //            v.z = float.Parse(Line.Substring(37, 13));//z
            //            else //Negative x,y and Positive z
            //                v.z = float.Parse(Line.Substring(37, 12));//z
            //        }
            //        else //Negative x and Positive y
            //        {
            //            v.y = float.Parse(Line.Substring(24, 12)); //y
            //            if(Line[36]=='-')//Negative x ,Positive y and Negative z
            //            v.z = float.Parse(Line.Substring(36,13));//z
            //            //Negative x and positive y,z
            //            v.z = float.Parse(Line.Substring(36, 12));//z

            //        }
            //    } 
            //    else //positive x
            //    {
            //        v.x = float.Parse(Line.Substring(11, 12)); //x
            //        if (Line[23] == '-')// Positive x and Negative y
            //        {
            //            v.y = float.Parse(Line.Substring(23, 13)); //y
            //            if (Line[36] == '-') //Positive  x and Negative y,z
            //                v.z = float.Parse(Line.Substring(36, 13));//z
            //            else //Positive x, Negative y and Positive z
            //                v.z = float.Parse(Line.Substring(36, 12));//z
            //        }
            //        else //Positive x and Positive y
            //        {
            //            v.y = float.Parse(Line.Substring(23, 12)); //y
            //            if (Line[35] == '-')//Positive x ,Positive y and Negative z
            //                v.z = float.Parse(Line.Substring(35, 13));//z
            //            //  positive x,y,z
            //            v.z = float.Parse(Line.Substring(35, 12));//z

            //        }
            //    }
            //    Normal_vector c = new Normal_vector(0, 0, 0);
            //    c.x = v.x;
            //    c.y = v.y;
            //    c.z = v.z;
            //        normal_vectors.Vectors.Add(c);

            //            //----------------------------------------------------------------------
            //            Line = File_text.ReadLine().Trim().Replace(" ", ""); // OuterLoop
            //            //----------------------------------------------------------------------
            //            // Vertex1,2 and 3
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Line = File_text.ReadLine().Trim().Replace(" ", "");
            //        if (Line[6] == '-') // Negative x

            //        {
            //            P.x = float.Parse(Line.Substring(6, 13)); //x
            //            if (Line[19] == '-')// Negative x and Negative y
            //            {
            //                P.y = float.Parse(Line.Substring(19, 13)); //y
            //                if (Line[32] == '-') //Negative x,y,z
            //                    P.z = float.Parse(Line.Substring(32, 13));//z
            //                else //Negative x,y and Positive z
            //                    P.z = float.Parse(Line.Substring(32, 12));//z
            //            }
            //            else //Negative x and Positive y
            //            {
            //                P.y = float.Parse(Line.Substring(19, 12)); //y
            //                if (Line[31] == '-')//Negative x ,Positive y and Negative z
            //                    P.z = float.Parse(Line.Substring(31, 13));//z
            //                          //Negative x and positive y,z
            //                P.z = float.Parse(Line.Substring(31, 12));//z

            //            }
            //        }
            //        else //positive x
            //        {
            //            P.x = float.Parse(Line.Substring(6, 12)); //x
            //            if (Line[18] == '-')// Positive x and Negative y
            //            {
            //                P.y = float.Parse(Line.Substring(18, 13)); //y
            //                if (Line[31] == '-') //Positive  x and Negative y,z
            //                    P.z = float.Parse(Line.Substring(31, 13));//z
            //                else //Positive x, Negative y and Positive z
            //                    P.z = float.Parse(Line.Substring(31, 12));//z
            //            }
            //            else //Positive x and Positive y
            //            {
            //                P.y = float.Parse(Line.Substring(18, 12)); //y
            //                if (Line[30] == '-')//Positive x ,Positive y and Negative z
            //                    P.z = float.Parse(Line.Substring(30, 13));//z
            //                                                               //  positive x,y,z
            //                P.z = float.Parse(Line.Substring(30, 12));//z

            //            }
            //        }
            //        Point J = new Point(0, 0, 0);
            //        J.x = P.x;
            //        J.y = P.y;
            //        J.z = P.z;
            //        T[i] = J;
            //        list.add(J);
            //    }           //construction of Lines
            //    line lin = new line();
            //    lin.point_start =T[0];
            //        lin.point_end = T[ 1];
            //        L.add(lin);
            //    line lim = new line();
            //    lim.point_start = T[0];
            //        lim.point_end = T[ 2];
            //        L.add(lim);
            //    line lil = new line();
            //    lil.point_start =T[ 1];
            //        lil.point_end = T[ 2];
            //        L.add(lil);
            //    //add the Line to the Pointlist
            //    list.add(lin);
            //    list.add(lim);
            //    list.add(lil);
            //    //-----------------------------------------
            //    s.line1 = lin;
            //    s.line2 = lim;
            //    s.line3 = lil;
            //    //add the surface to the list from lines
            //    L.add(s);
            //    //add the surface to the list from Surfaces
            //    lists.Surfaceliste.Add(s);


            //    //----------------------------------------------------------------------
            //    Line = File_text.ReadLine().Trim().Replace(" ", ""); // EndLoop
            //            //----------------------------------------------------------------------
            //            Line = File_text.ReadLine().Trim().Replace(" ", ""); // endfacet
            //        }
            //}
            //File_text.Close();
        }

        public float Bin_Reader(Normal_Vectors normal_vectors, Pointlist list, Linelist L, Surfacelist lists,
            string Path)
        {
            float X, Y, Z;
            Point[] T = new Point[3];
            Surface s = new Surface();
            BinaryReader reader = new BinaryReader(File.Open(Path, FileMode.Open));
            const int floatSize = sizeof(float);
            const int vertexSize = (floatSize * 3);
            byte[] data = new byte[vertexSize];
            float h = 0;
            if (reader.ReadBytes(80) != null)
            {
                h = reader.ReadUInt32();
                for (int i = 0; i < h; i++)
                {
                    reader.Read(data, 0, data.Length);
                    X = BitConverter.ToSingle(data, 0);
                    Y = BitConverter.ToSingle(data, floatSize);
                    Z = BitConverter.ToSingle(data, (floatSize * 2));
                    Normal_vector v = new Normal_vector(0, 0, 0);
                    v.x = X;
                    v.y = Y;
                    v.z = Z;
                    normal_vectors.Vectors.Add(v);
                    for (int j = 0; j < 3; j++)
                    {
                        reader.Read(data, 0, data.Length);
                        X = BitConverter.ToSingle(data, 0);
                        Y = BitConverter.ToSingle(data, floatSize);
                        Z = BitConverter.ToSingle(data, (floatSize * 2));
                        Point c = new Point(0, 0, 0);
                        c.x = X;
                        c.y = Y;
                        c.z = Z;
                        list.add(c);
                        T[j] = c;
                    }
                    //construction of Lines
                    line lin = new line();
                    lin.point_start = T[0];
                    lin.point_end = T[1];
                    L.add(lin);
                    line lim = new line();
                    lim.point_start = T[0];
                    lim.point_end = T[2];
                    L.add(lim);
                    line lil = new line();
                    lil.point_start = T[1];
                    lil.point_end = T[2];
                    L.add(lil);
                    //add the Line to the Pointlist
                    list.add(lin);
                    list.add(lim);
                    list.add(lil);
                    //-----------------------------------------
                    s.line1 = lin;
                    s.line2 = lim;
                    s.line3 = lil;
                    //add the surface to the list from lines
                    L.add(s);
                    //add the surface to the list from Surfaces
                    lists.Surfaceliste.Add(s);

                    //----------------------------------------------------------
                    reader.ReadUInt16();
                }
            }
            reader.Close();
            return h;
        }
    }
}