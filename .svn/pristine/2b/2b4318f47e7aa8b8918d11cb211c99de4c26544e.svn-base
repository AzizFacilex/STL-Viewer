using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.Platform.Windows;
using Tao.FreeGlut;
using Tao.OpenGl;
using System.Globalization;
using System.Threading;
using System.IO;
using StlReader;
namespace StlViewer
{
    public partial class Objekt : Form
    {
        
        private static List<float> pointlist = new List<float> { };
        private static List<float> normallist = new List<float> { };
        private static float[] pointarray;
        private static float[] normalarray;
        Pointlist points;
        Normal_Vectors normals;
        string gewähltefarbe;
        private static int width = 1280, height = 720;
        private static float rotx, roty, rotz = 0;
        private static double zoom = 70;
        private static bool leftmouseDown, rightmouseDown = false;
        private static int downX, downY;
        private static int prevX, prevY;
        private static bool fullscreen = false;
        private static float translatex, translatey = 0;
        float[] light = new float[] { 0.15f, 0.15f, 0.15f, 1.0f };
        float[] light2 = new float[] { 0.35f, 0.35f, 0.35f, 1.0f };
        float[] diffuselight = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        float[] diffuselight2 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        float[] lightPos = new float[] { 600f, 600f, -600.0f, 1.0f };
        float[] lightPos2 = new float[] { -600f, 600f, -600.0f, 1.0f };
        private static float a = 0f;
        private static float b = 0.4f;
        private static float c=0.4f;
        public Objekt(Pointlist point, Normal_Vectors normal, ComboBox Combo)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");           
            points = point;
            normals = normal;
            gewähltefarbe = Combo.Text;
            InitializeComponent();
            InitializeComponent();
        }
        private static void Konvertion (Pointlist point, Normal_Vectors normal)
        {
            foreach(StlReader.Normal_vector O in normal.Vectors)
            {
                normallist.Add(O.x);
                normallist.Add(O.y);
                normallist.Add(O.z);
            }
            normalarray = normallist.ToArray<float>();
            foreach (KeyValuePair<StlReader.Point, List<line>> kvp in point.d)
            {
                pointlist.Add(kvp.Key.x);
                pointlist.Add(kvp.Key.y);
                pointlist.Add(kvp.Key.z);
            }
            pointarray = pointlist.ToArray<float>();
        }
        private static void OnKeyboardMoves(byte key, int x, int y)
        {
            if (key == 'a') rotx = rotx + 3;
            else if (key == 'z') rotx = rotx - 3;
            else if (key == 'e') roty = roty + 3;
            else if (key == 'r') roty = roty - 3;
            else if (key == 't') rotz = rotz + 3;
            else if (key == 'y') rotz = rotz - 3;
            else if (key == '+') zoom = zoom + 3;
            else if (key == '-') zoom = zoom - 3;
            else if (key == 'q') translatex = translatex + 1;
            else if (key == 's') translatex = translatex - 1;
            else if (key == 'd') translatey = translatey + 1;
            else if (key == 'g') translatey = translatey - 1;
            if (key == 'f')
            {
                fullscreen = !fullscreen;
                if (fullscreen) Glut.glutFullScreen();
                else
                {
                    Glut.glutPositionWindow(0, 0);
                    Glut.glutReshapeWindow(1280, 720);
                }
            }
        }
        private static void Windowreshape(int x, int y)
        {
            width = x;
            height = y;
        }
        private static void Mousewheel(int button, int dir, int x, int y)
        {
            if (dir > 0) { zoom = zoom + 3; }  // Zoom in        
            else { zoom = zoom - 3; }               // Zoom out
        }
        private static void OnMouseMoves(int button, int state, int x, int y)
        {
            if (button == Glut.GLUT_RIGHT_BUTTON)
            {
                // this method gets called whenever a new mouse button event happens
                rightmouseDown = (state == Glut.GLUT_DOWN);
                // if the mouse has just been clicked then we hide the cursor and store the position
                if (rightmouseDown)
                {
                    Glut.glutSetCursor(Glut.GLUT_CURSOR_NONE);
                    prevX = downX = x;
                    prevY = downY = y;
                }
                else // unhide the cursor if the mouse has just been released
                {
                    Glut.glutSetCursor(Glut.GLUT_CURSOR_LEFT_ARROW);
                    Glut.glutWarpPointer(downX, downY);
                }
            }
            if (button == Glut.GLUT_LEFT_BUTTON)
            {
                leftmouseDown = (state == Glut.GLUT_DOWN);
                if (leftmouseDown)
                {
                    Glut.glutSetCursor(Glut.GLUT_CURSOR_NONE);
                    prevX = downX = x;
                    prevY = downY = y;
                }
                else Glut.glutSetCursor(Glut.GLUT_CURSOR_LEFT_ARROW);
            }
        }
        private static void OnMove(int x, int y)
        {
            // if the mouse move event is caused by glutWarpPointer then do nothing
            if (x == prevX && y == prevY) return;
            // move the camera when the mouse is down
            if (rightmouseDown)
            {
                rotx = rotx - (y - prevY);
                roty = roty - (x - prevX);
                prevX = x;
                prevY = y;
            }
            else if (leftmouseDown)
            {
                translatex = (translatex + (x - prevX)) - 0.0000005f;
                translatey = (translatey - (y - prevY)) - 0.0000005f;
                prevX = x;
                prevY = y;
            }
            if (x < 0) Glut.glutWarpPointer(prevX = width, y);
            else if (x > width) Glut.glutWarpPointer(prevX = 0, y);
            if (y < 0) Glut.glutWarpPointer(x, prevY = height);
            else if (y > height) Glut.glutWarpPointer(x, prevY = 0);
        }
        private static void color(string test)
        {
           if ( test == "Rot")
            {
                 a = 1.0f;
                b = 0.0f;
                c = 0.0f;
            }
            if (test == "Grün")
            {
                a = 0.0f;
                b = 1.0f;
                c = 0.0f;
            }
            if (test == "Blau")
            {
                a = 0.0f;
                b = 0.0f;
                c = 1.0f;
            }
            if (test == "Default")
            {
                a = 0.0f;
                b = 0.4f;
                c = 0.4f;
            }
        }

        private void Objekt_Load(object sender, EventArgs e)
        {
            // OpenGL Window Initialisation ( GLUT )
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("STL Viewer");
            Glut.glutInitWindowPosition(300, -300);
            Glut.glutKeyboardUpFunc(OnKeyboardMoves);
            Glut.glutReshapeFunc(Windowreshape);
            Glut.glutMouseWheelFunc(Mousewheel);
            Glut.glutMouseFunc(OnMouseMoves);
            Glut.glutMotionFunc(OnMove);
            // Glut running functions           
            Glut.glutIdleFunc(OnRenderFrame);
            Glut.glutDisplayFunc(OnDisplay);
            // OpenGL Loop Method
            Glut.glutMainLoop();
        }
        private static void OnDisplay()
        {
        }
        private void OnRenderFrame()
        {
            // OpenGL viewport and clear both the color and depth bits
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-640, 640, -360, 360, 300, -300); // Ursprung
            Gl.glClearDepth(1.0f);          // Set the Depth buffer value
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glDepthFunc(Gl.GL_LEQUAL);
            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0.20f, 0.20f, 0.20f, 1); // Background Color
            Gl.glScaled(zoom, zoom, zoom); // Zoom Method
            Konvertion(points, normals);
            color(gewähltefarbe);
            Gl.glPushMatrix(); // Load Matrix
            Gl.glEnableClientState(Gl.GL_NORMAL_ARRAY); // enable normal array
            Gl.glColor3f(a, b, c);
            Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY); // enable vertex array
            Gl.glNormalPointer(Gl.GL_FLOAT, 0, normalarray); // Normal pointer
            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, pointarray); // vertices pointer
            Gl.glTranslatef(translatex, 0, 0); // translation X Achse
            Gl.glTranslatef(0, translatey, 0); // translation Y Achse
            Gl.glRotatef(rotx, 1, 0, 0); // rotation X Achse
            Gl.glRotatef(roty, 0, 1, 0); // rotation Y Achse
            Gl.glRotatef(rotz, 0, 0, 1); // rotation Z Achse            
            Gl.glDrawArrays(Gl.GL_TRIANGLES, 0, normalarray.Length/3); // Draw arrays ( Vertices color and Normal )
            Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY);  // disable vertex arrays
            Gl.glDisableClientState(Gl.GL_NORMAL_ARRAY); // disable normal arrays
            Gl.glPopMatrix(); // Save Matrix
            // Enable lighing
            Gl.glEnable(Gl.GL_LIGHTING); // Enables Lightning- Base Method
            Gl.glEnable(Gl.GL_LIGHT5); // Light number 0 used
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_AMBIENT, light); // Umgebungslicht
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_DIFFUSE, light2); // diffuses licht
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_SPECULAR, diffuselight); // Lichtreflexion
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_POSITION, lightPos); // Licht Position
            //----Light 2----//
            Gl.glEnable(Gl.GL_LIGHT1);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_AMBIENT, light); // Umgebungslicht 2
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_DIFFUSE, light2); // diffuses Licht 2
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_SPECULAR, diffuselight2); // Lichtreflexion 2
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, lightPos2); // Licht Position 2
            //----Material lightning----//
            Gl.glEnable(Gl.GL_COLOR_MATERIAL); // Enables Material color
            Gl.glColorMaterial(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, diffuselight2); // Lichtreflexion MAterial
            Gl.glMateriali(Gl.GL_FRONT, Gl.GL_SHININESS, 10); // Reflexion Level
            Gl.glEnable(Gl.GL_NORMALIZE); // Light Transition
            Glut.glutSwapBuffers();
        }
    }
}
