using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArraylistExamplePhoneDirectory.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace ArraylistExamplePhoneDirectory.Helpers
{
    public class Manager
    {
        public static  ArrayList memberList = new ArrayList()
        {

            new ContactModel
            {
                Id = 1,
                Name = "tarık",
                Surname = "gulyuva",
                Phone = "554351010"
            },
            new ContactModel
            {
                Id = 2,
                Name = "Hakan",
                Surname = "Acar",
                Phone = "554554545"
            }
        };
        public static ArrayList SearcArrayList = new ArrayList();

        public void Add(ContactModel model)
        {

            model.Id = memberList.Count + 1;


            memberList.Add(model);

        }

        public void Update(ContactModel model)
        {
            var i = model.Id - 1;
            memberList[i] = model;

        }
        public void Remove(int id)
        {
            id--;
            memberList.RemoveAt(id);

        }

       
        public ArrayList ListAll()
        { 
            return memberList;
        }


        public ContactModel GetById(int id)
        {
            var aaa = ListAll();
            id--;
            return (ContactModel)aaa[id];
        }

        public ArrayList SearcList(string key)
        {
            SearcArrayList.Clear();
            foreach (ContactModel model in memberList)
            {
                if (model.Name.Contains(key)||model.Phone.Contains(key) || model.Surname.Contains(key))
                {
                    SearcArrayList.Add(model);
                }
              
            }
            
            return SearcArrayList;
        }
        public ArrayList SearchArrayListAll()
        {
            return SearcArrayList;
        }
    }
}