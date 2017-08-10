using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AgainstAlzheimerLibrary
{
    public class Reminders
    {
        private String mNames;
        private String mLastNames;
        private int mAge;
        private DateTime mBirthday;
        private String mWhereBorn;
        private String mCity;
        private String mAddress;

        private String mFamily1;
        private String mFamily2;
        private String mFamily3;
        private String mFamily4;
        private String mFamily5;
        private String mFamily6;
        private String mFamily7;
        private String mFamily8;

        private String mVideo;

        public string Names
        {
            get { return mNames; }

            set { mNames = value; }
        }

        public string LastNames
        {
            get { return mLastNames; }

            set { mLastNames = value; }
        }

        public int Age
        {
            get { return mAge; }

            set { mAge = value; }
        }

        public DateTime Birthday
        {
            get { return mBirthday; }

            set { mBirthday = value; }
        }

        public string WhereBorn
        {
            get { return mWhereBorn; }

            set { mWhereBorn = value; }
        }

        public string City
        {
            get { return mCity; }

            set { mCity = value; }
        }

        public string Address
        {
            get { return mAddress; }

            set { mAddress = value; }
        }

        public string Family1
        {
            get { return mFamily1; }

            set { mFamily1 = value; }
        }

        public string Family2
        {
            get { return mFamily2; }

            set { mFamily2 = value; }
        }

        public string Family3
        {
            get { return mFamily3; }

            set { mFamily3 = value; }
        }

        public string Family4
        {
            get { return mFamily4; }

            set { mFamily4 = value; }
        }

        public string Family5
        {
            get { return mFamily5; }

            set { mFamily5 = value; }
        }

        public string Family6
        {
            get { return mFamily6; }

            set { mFamily6 = value; }
        }

        public string Family7
        {
            get { return mFamily7; }

            set { mFamily7 = value; }
        }

        public string Family8
        {
            get { return mFamily8; }

            set { mFamily8 = value; }
        }

        public string Video
        {
            get { return mVideo; }

            set { mVideo = value; }
        }


        public void SetPicsOfFamily(PictureBox picFamily1, PictureBox picFamily2, PictureBox picFamily3, PictureBox picFamily4,
                                        PictureBox picFamily5, PictureBox picFamily6, PictureBox picFamily7, PictureBox picFamily8)
        {

        }

        public void SetNameOfVideo(TextBox txtVideo)
        {
            mVideo = txtVideo.Text;
        }
    }
}
