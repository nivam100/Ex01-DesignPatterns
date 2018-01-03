using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    class ProxyFBService : FacebookService
    {
        private static UserProxy m_user;
        private static LoginResult m_loginResult;
        // TODO change to false
        public static bool LoadSavedUser = true;

        public static LoginResult Login(string i_AppId, params string[] i_Permissions)
        {

            LoginResult loadedResult = null;
            bool failedToLoadResult = true;
            if (LoadSavedUser)
            {
                loadedResult = Open();
                failedToLoadResult = loadedResult == null;
            }
            if (failedToLoadResult)
            {
                System.Console.Error.WriteLine("failed to load file");
                return FacebookService.Login(i_AppId, i_Permissions);
            }
            else
            {
                System.Console.Error.WriteLine("Loaded file woooohooo");
                return loadedResult;
            }
        }
        
    }

    class UserProxy : FacebookWrapper.ObjectModel.User
    {
        private User m_newUser;
        private User m_oldUser;
        public void Save()
        {
            using (Stream stream = new FileStream("UserCache.bin", FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, m_user);
                stream.Flush();
            }
                 
        }
 
        public User open()
        {
            try
            {
                using (Stream stream = new FileStream("UserCache.bin", FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    User loadedUser = (User)formatter.Deserialize(stream);
                    return loadedUser;
                }
               
            }
            catch(FileNotFoundException e)
            {
                return null;
            }  
            catch(Exception e)
            {
                System.Console.Error.WriteLine(e);
                return null;
            }
        }
    }
}
