
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Dtos;
using DataAcessLayer.ApplicationContext;
using DataAcessLayer.CRUDoperations;


namespace BusinessLayer.Service
{
    public class ManageRegisteration : IManageRegisteration
    {
        private readonly IUser _user;
       
        public ManageRegisteration(IUser user)
        {
            _user = user;
        }
        public void addRegisteration(RegisterationModel model)
        {
            Registeration reg = new Registeration()
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
            };
            _user.add(reg);
        }
    }
}
