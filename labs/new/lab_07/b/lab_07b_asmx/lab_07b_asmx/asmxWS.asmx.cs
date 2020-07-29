using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication.Db;
using WebApplication.Db.jsonImpl;
using WebApplication.Db.msImpl;
using WebApplication.Models;

namespace lab_07b_asmx
{

    // http://localhost:14882/asmxWS.asmx

    /// <summary>
    /// Сводное описание для asmxWS
    /// </summary>
    [WebService(Namespace = "http://valera.com/")] // пространство имён
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)] // спецификация совместимости web-служб
    [System.ComponentModel.ToolboxItem(false)] // управление памелью элементов VS ToolBox
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class asmxWS : WebService
    {

        // UserContextFactory userFactory = new UserContextFactory();
        UserFactory userFactory = new UserFactory();

        [WebMethod(Description = "Get all contacts", EnableSession = true)]
        public List<User> GetData()
        {
            return userFactory.GetAll();
        }

        [WebMethod(Description = "Add new conact", EnableSession = true)]
        public void AddData(User user)
        {
            userFactory.Create(user);
        }

        [WebMethod(Description = "Update contact", EnableSession = true)]
        public void UpdateData(User user)
        {
            userFactory.Update(user);
        }

        [WebMethod(Description = "Delete contact by id", EnableSession = true)]
        public void DeleteData(int id)
        {
            userFactory.Delete(id);
        }

    }
}
