using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;

namespace ActiveDirectory
{
    public class UsuarioAD
    {
        private String _fisrtName;       //*
        private String _lastName;        //*
        private String _loginName;       //*
        private String _telephoneNumber; //*
        private String _email;           //*
        private String _department;      //*
        private String _manager;    
        private String _secretaria;      // *
        private String _managerName;     // *

        // Construtor

        private UsuarioAD(DirectoryEntry user)
        {
            
        }


        public String ManagerName
        {
            get { return _managerName; }
        }

        public String Department
        {
            get { return _department; }
        }

        public String FirstName
        {
            get { return _fisrtName; }
        }

        public String Lastname
        {
            get { return _lastName; }
        }

        public String LoginName
        {
            get { return _loginName; }
        }

        public String Secretaria
        {
            get { return _secretaria; }
        }

        public String EMail
        {
            get { return _email; }
        }

        public String TelephoneNumber
        {
            get { return _telephoneNumber; }
        }

        public UsuarioAD Manager
        {
            get
            {
                if (!String.IsNullOrEmpty(_managerName))
                {
                    //objeto classe activedirectory helper

                }
                
                return null;
            }
        }



        



        
        
    }
}
