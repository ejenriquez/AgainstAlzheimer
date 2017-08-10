using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using ShockwaveFlashObjects;
using AxShockwaveFlashObjects;

namespace AgainstAlzheimerLibrary
{
    public class Animation
    {
        #region Atributes of the class
        ///<summary>
        /// Member data (variables).
        ///</summary>

        private string mPath;

        #endregion

        #region Properties
        ///<summary>
        /// Manage access descriptors (get & set).
        ///</summary>

        public string Path
        {
            get { return mPath; }
            set { mPath = value; }
        }

        #endregion

        #region Constructors of the class
        ///<summary>
        /// Constructors Functions.
        ///</summary>

        // Constructor by defect.
        public Animation()
        {
            mPath = "";
        }

        #endregion

        #region Methods
        ///<summary>
        /// Member functions.
        ///</summary>       

        public void LoadFlashAnimation(AxShockwaveFlash ObjShockwaveFlash, string path)
        {
            Path = System.Environment.CurrentDirectory;
            Path += path;
            ObjShockwaveFlash.LoadMovie(0, Path);
        }

        public void PlayFlashAnimation(AxShockwaveFlash ObjShockwaveFlash)
        {
            ObjShockwaveFlash.Play();
        }

        public void StopFlashAnimation(AxShockwaveFlash ObjShockwaveFlash)
        {
            ObjShockwaveFlash.Stop();
        }

        #endregion
    }
}
