using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public  class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            List<InputOutputEntity> inputOutputs = new List<InputOutputEntity>();
            using (var db = new InventaryContext())
            {
                return db.InputOutputs.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Update(oInputOutput);
                db.SaveChanges();
            }
        }

    }
}
