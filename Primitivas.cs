//HANSEL. 
//LALO..
//LILO..
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using OpenGL;

namespace ComputacionGraficaPrimitivas
{
    /// <summary>
    /// Implementacion de BaseGLControl
    /// </summary>
    /// 

    //https://creativemarket.com/AlexRoka/4127-3D-Geometric-Shapes
    //https://creativemarket.com/AlexRoka/4127-3D-Geometric-Shapes/screenshots/#screenshot1
    //https://creativemarket.com/AlexRoka/4127-3D-Geometric-Shapes/screenshots/#screenshot2
    //https://creativemarket.com/AlexRoka/4127-3D-Geometric-Shapes/screenshots/#screenshot3

    public class Primitivas : BaseGLControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        bool direction = false;

        public Primitivas(bool direction)
        {
            InitializeComponent();

            this.direction = direction;
            this.KeyPress += new KeyPressEventHandler(TestGL_KeyPress);
        }

        /// <summary> 
        /// Limpua Recursos
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Name = "Primitivas";
            this.Load += new System.EventHandler(this.Primitivas_Load);
            this.ResumeLayout(false);

        }
        #endregion

        float angle = 0;

        /// <summary>
        /// Pinta la Escena
        /// </summary>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (DC == 0 || RC == 0)
                return;

            GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            GL.glLoadIdentity();

            Primitiva3DCubo();

            GL.glLoadIdentity();

            letra_k();

            GL.glLoadIdentity();

            letra_e();

            GL.glLoadIdentity();

            letra_v();

            GL.glLoadIdentity();

            letra_i();

            GL.glLoadIdentity();

            letra_n();

            GL.glLoadIdentity();

            letra_t();


            GL.glLoadIdentity();

            letra_c();

            GL.glLoadIdentity();

            letra_a();

            GL.glLoadIdentity();

            letra_n2();

            /*GL.glLoadIdentity();

            letra_t2();*/

            GL.glLoadIdentity();

            triangulo_rectangulo();

            GL.glLoadIdentity();

            triangulo_rectangulo_bajo();

            GL.glLoadIdentity();

            piramide_tipoa();

            

           
            GL.glFlush();

            WGL.wglSwapBuffers(DC);

            angle += 0.45f;
        }

        private void Primitiva3DCubo()
        {
            GL.glTranslatef(-13.0f, 6.0f, -15.0f);

            GL.glRotatef(angle, 1.0f, 1.0f, 0.0f);

            GL.glScalef(1.0f, 1.0f, 1.0f);

            GL.glBegin(GL.GL_TRIANGLES);


            //BASE
            //////////////tRIANGULO 1
            //RMF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.0f);
            //LMF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            ///////////////TRI픎GULO 2
            //LMF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //LMB
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);


            //CARA 1
            /////////////TRI픎GULO 1
            //LMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            ///////////////TRI픎GULO 2
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //RMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.0f);
            //LMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);


            //CARA 2
            ////////////////TRI픎GULO 2
            //LMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            //LMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            ///////////////TRI픎GULO 1
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //LTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, -1.0f);
            //LMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);

            //CARA 3
            /////////////////////TRI픎GULO 1
            //RMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            //////////////TRI픎GULO 2
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            //RTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);


            //CARA 4
            /////////////////////TRI픎GULO 1
            //RTB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);
            //RMB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            //LMB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            ///////////////////////TRI픎GULO 2
            //LMB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            //LTB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, -1.0f);
            //RTB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);


            //ARRIBA
            //////////////////////////////TRI픎GULO 1
            //RTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //LTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //RTB
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);
            ////////////////////////////////TRI픎GULO 2
            //RTB
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);
            //LTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //LTB
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, -1.0f);

            GL.glEnd();
        }


        private void triangulo_rectangulo()
        {
            GL.glTranslatef(-8.0f, 6.0f, -15.0f);

            GL.glRotatef(angle, 0.0f, 1.0f, 0.0f);

            GL.glScalef(1.0f, 1.0f, 1.0f);

            GL.glBegin(GL.GL_TRIANGLES);

            //CARA PRINCIPAL
            //LTF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LDF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //CARA ATRAS
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 0.0f);
            //CARA 
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 0.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //CARA BAJA
            //RTF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //LDF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 0.0f);


            GL.glEnd();
        }

        private void triangulo_rectangulo_bajo()
        {
            GL.glTranslatef(-3.0f, 6.0f, -15.0f);

            GL.glRotatef(angle, 0.0f, 1.0f, 0.0f);

            GL.glScalef(1.0f, 1.0f, 1.0f);

            GL.glBegin(GL.GL_TRIANGLES);

            //CARA PRINCIPAL
            //LDF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //LTF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //RDF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, -1.0f, 1.0f);
            //CARA ATRAS
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, -1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 0.0f);
            //CARA 
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 0.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //CARA BAJA
            //RTF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, -1.0f, 1.0f);
            //LDF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 0.0f);


            GL.glEnd();
        }

        private void piramide_tipoa()
        {
            GL.glTranslatef(2.0f, 6.0f, -15.0f);

            GL.glRotatef(angle, 1.0f, 0.0f, 0.0f);

            GL.glScalef(1.0f, 1.0f, 1.0f);

            GL.glBegin(GL.GL_TRIANGLES);

            //CARA PRINCIPAL
            //LTF
            GL.glColor3f(.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //RTF
            GL.glColor3f(.0f, 255.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //MDM
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);

            //CARA ATRAS
            //LTB
            GL.glColor3f(.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, -1.0f);
            //RTB
            GL.glColor3f(.0f, 255.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //MDM
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);

            //CARA IZQUIERDA
            //LTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, -1.0f);
            //LTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //MDM
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);

            //CARA DERECHA
            //RTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //RTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //MDM
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);


            //CUADRADO

            //TRIANGULO 1
            //RTB
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //RTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //TRIANGULO 2
            //RTB
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LTB
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, -1.0f);
            
            GL.glEnd();
        }



        private void Primitiva3DCubo(float x, float y, float z, float i, float j, float k)
        {
            GL.glTranslatef(x, y, z);

            //GL.glRotatef(angle, 0.0f, 1.0f, 0.0f);

            GL.glScalef(i, j, k);

            GL.glBegin(GL.GL_TRIANGLES);

            
            //BASE
            //////////////tRIANGULO 1
            //RMF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.0f);
            //LMF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            ///////////////TRI픎GULO 2
            //LMF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //LMB
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);


            //CARA 1
            /////////////TRI픎GULO 1
            //LMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            ///////////////TRI픎GULO 2
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //RMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.0f);
            //LMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);


            //CARA 2
            ////////////////TRI픎GULO 2
            //LMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            //LMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, 1.0f);
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            ///////////////TRI픎GULO 1
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //LTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, -1.0f);
            //LMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);

            //CARA 3
            /////////////////////TRI픎GULO 1
            //RMF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            //////////////TRI픎GULO 2
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //RMB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            //RTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);


            //CARA 4
            /////////////////////TRI픎GULO 1
            //RTB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);
            //RMB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, -1.0f);
            //LMB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            ///////////////////////TRI픎GULO 2
            //LMB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 0.0f, -1.0f);
            //LTB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, -1.0f);
            //RTB
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);


            //ARRIBA
            //////////////////////////////TRI픎GULO 1
            //RTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, 1.0f);
            //LTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //RTB
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);
            ////////////////////////////////TRI픎GULO 2
            //RTB
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 2.0f, -1.0f);
            //LTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, 1.0f);
            //LTB
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 2.0f, -1.0f);

            GL.glEnd();
        }

        private void triangulo_rectangulo(float x1, float y2, float z3, float i1, float j2, float k3)
        {
            GL.glTranslatef(x1, y2, z3);

           //GL.glRotatef(angle, 0.0f, 1.0f, 0.0f);

            GL.glScalef(i1, j2, k3);

            GL.glBegin(GL.GL_TRIANGLES);

            //CARA PRINCIPAL
            //LTF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LDF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //CARA ATRAS
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 0.0f);
            //CARA 
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 0.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //CARA BAJA
            //RTF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //LDF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 0.0f);


            GL.glEnd();
        }

        private void triangulo_rectangulo_bajo(float x4, float y4, float z4, float i4, float j4, float k4)
        {
            GL.glTranslatef(x4, y4, z4);

            //GL.glRotatef(angle, 0.0f, 1.0f, 0.0f);

            GL.glScalef(i4, j4, k4);

            GL.glBegin(GL.GL_TRIANGLES);

            //CARA PRINCIPAL
            //LDF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //LTF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //RDF
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, -1.0f, 1.0f);
            //CARA ATRAS
            //LTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //RTF
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, -1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 0.0f);
            //CARA 
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, -1.0f, 1.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 0.0f);
            //LDF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //CARA BAJA
            //RTF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, -1.0f, 1.0f);
            //LDF
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LDM
            GL.glColor3f(255.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 0.0f);


            GL.glEnd();
        }

        private void piramide_tipoa(float x5, float y5, float z5, float i5, float j5, float k5)
        {
            GL.glTranslatef(x5, y5, z5);

            //GL.glRotatef(angle, 0.0f, 1.0f, 0.0f);

            GL.glScalef(i5, j5, k5);

            GL.glBegin(GL.GL_TRIANGLES);

            //CARA PRINCIPAL
            //LTF
            GL.glColor3f(.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //RTF
            GL.glColor3f(.0f, 255.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //MDM
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);

            //CARA ATRAS
            //LTB
            GL.glColor3f(.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, -1.0f);
            //RTB
            GL.glColor3f(.0f, 255.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //MDM
            GL.glColor3f(255.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);

            //CARA IZQUIERDA
            //LTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, -1.0f);
            //LTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //MDM
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);

            //CARA DERECHA
            //RTB
            GL.glColor3f(255.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //RTF
            GL.glColor3f(0.0f, 255.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //MDM
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(0.0f, -1.0f, 0.0f);


            //CUADRADO

            //TRIANGULO 1
            //RTB
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //RTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.0f);
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //TRIANGULO 2
            //RTB
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(1.0f, 1.0f, -1.0f);
            //LTF
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, 1.0f);
            //LTB
            GL.glColor3f(0.0f, 0.0f, 255.0f);
            GL.glVertex3f(-1.0f, 1.0f, -1.0f);

            GL.glEnd();
        }


        void letra_k()
        {

            
            GL.glLoadIdentity();

            Primitiva3DCubo(-18, -3, -20, 1.0f, 4.0f, 1.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo(-15, 3, -21, 2.0f, 2.0f, 2.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(-15, -1, -21, 2.0f, 2.0f, 2.0f);

        
        
        
        }

        void letra_e()
        {

            GL.glLoadIdentity();

            triangulo_rectangulo(-10, 3, -21, 2.0f, 2.0f, 2.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(-10, -1, -21, 2.0f, 2.0f, 2.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo(-10, 0, -21, 2.0f, 2.0f, 2.0f);
            
                

        }

        void letra_v()
        {
            GL.glLoadIdentity();

            piramide_tipoa(-5, 1, -20, 2.0f, 4.0f, 1.0f);


        }

        void letra_i()
        {
            GL.glLoadIdentity();

            Primitiva3DCubo(-1, -3, -20, 1.0f, 4.0f, 1.0f);
        }

        void letra_n()
        {
            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(5, 1, -21, 3.0f, 4.0f, 1.0f);

            GL.glLoadIdentity();

            Primitiva3DCubo(7, -3, -21, 1.0f, 4.0f, 1.0f);


        }

        void letra_t()
        {

            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(14, 4, -21, 4.0f, 1.0f, 3.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo(14, 4, -21, -4.0f, 1.0f, 3.0f);
            
            GL.glLoadIdentity();

            Primitiva3DCubo(15, -3, -20, 1.0f, 4.0f, 1.0f);
        }

        private void letra_t(float x, float y, float z)
        {
         

            GL.glTranslatef(x, y, z);

            GL.glBegin(GL.GL_TRIANGLES);


            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(14, 4, -21, 4.0f, 1.0f, 3.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo(14, 4, -21, -4.0f, 1.0f, 3.0f);

            GL.glLoadIdentity();

            Primitiva3DCubo(15, -3, -20, 1.0f, 4.0f, 1.0f);

            GL.glEnd();
        }

        void letra_c()
        {
            GL.glLoadIdentity();

            triangulo_rectangulo(-40, -16, -40, 2.0f, 2.0f, 2.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(-40, -20, -40, 2.0f, 2.0f, 2.0f);

        }

        void letra_a()
        {

            GL.glLoadIdentity();

            piramide_tipoa(-36, -18, -40, 2.0f, -4.0f, 1.0f);

        }

        void letra_n2()
        {
            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(-28, -19, -40, 3.0f, 4.0f, 1.0f);

            GL.glLoadIdentity();

            Primitiva3DCubo(-26, -23, -40, 1.0f, 4.0f, 1.0f);

            GL.glLoadIdentity();

            letra_t (25, -12, -45);
        }

      /*  void letra_t2()
        {

            GL.glLoadIdentity();

            triangulo_rectangulo_bajo(14, 4, -21, 4.0f, 1.0f, 3.0f);

            GL.glLoadIdentity();

            triangulo_rectangulo(14, 4, -21, -4.0f, 1.0f, 3.0f);

            GL.glLoadIdentity();

            Primitiva3DCubo(15, -3, -20, 1.0f, 4.0f, 1.0f);
        }*/

        




        /// <summary>
        /// ESC para finalizar programa
        /// </summary>
        private void TestGL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                MainForm.App.Close();
        }

        private void Primitivas_Load(object sender, EventArgs e)
        {

        }
    }
}
