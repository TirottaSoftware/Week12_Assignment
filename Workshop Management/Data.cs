using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Management
{
    public static class Data
    {
        public static List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("people.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();

                if (fs.Length > 0)
                {
                    people = (List<Person>)bf.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return people;
        }
        public static void UpdatePeople(List<Person> people)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("people.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();

                bf.Serialize(fs, people);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public static List<Workshop> GetWorkshops()
        {
            List<Workshop> workshops = new List<Workshop>();
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("workshops.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();

                if (fs.Length > 0)
                {
                    workshops = (List<Workshop>)bf.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return workshops;
        }
        public static void UpdateWorkshops(List<Workshop> workshops)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("workshops.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();

                bf.Serialize(fs, workshops);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
