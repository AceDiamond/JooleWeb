using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb.Repo;
using System.Data.Entity;
using JooleWeb.DAL;

namespace JooleWeb.SEV
{
    public partial class Service
    {
        public Product getProductObj(int id)
        {
            Product product = uow.product.GetByID(id);
            return product;

        }
        public string getProductPrice(int id)
        {
            if (uow.product.GetByID(id).Price == null)
            {
                return "N/A";
            }
            return uow.product.GetByID(id).Price.ToString();
        }
        public string getProductDescription(int id)
        {
            if (uow.product.GetByID(id).Description == null)
            {
                return "N/A";
            }
            return uow.product.GetByID(id).Description.ToString();
        }

        public List<String> getProductSpec(int id)
        {
            List<String> listOfSub = new List<String>();

            string subID = uow.product.GetByID(id).SubcategoryID.ToString();
            int idForSub = id;
            if (subID == "1")
            {
                String displayType = uow.tv.GetByID(idForSub).DisplayType;
                String vertialRes = uow.tv.GetByID(idForSub).VerticalResolution;
                String screenSize = uow.tv.GetByID(idForSub).ScreenSize.ToString();
                listOfSub.Add(displayType);
                listOfSub.Add(vertialRes);
                listOfSub.Add(screenSize);
                return listOfSub;

            }

            if (subID == "2")
            {
                String videoRes = uow.theater.GetByID(idForSub).MaximumVideoResolution;
                String surroundSd = uow.theater.GetByID(idForSub).SurroundSound.ToString();
                String numberChannels = uow.theater.GetByID(idForSub).NumberofChannels.ToString();
                listOfSub.Add(videoRes);
                listOfSub.Add(surroundSd);
                listOfSub.Add(numberChannels);
                return listOfSub;

            }

            if (subID == "3")
            {
                String height = uow.chair.GetByID(idForSub).ProductHeight.ToString();
                String width = uow.chair.GetByID(idForSub).ProductWidth.ToString();
                String material = uow.chair.GetByID(idForSub).FrameMaterial;
                listOfSub.Add(height);
                listOfSub.Add(width);
                listOfSub.Add(material);
                return listOfSub;

            }

            if (subID == "4")
            {
                String height = uow.table.GetByID(idForSub).ProductHeight.ToString();
                String length = uow.table.GetByID(idForSub).ProductLength.ToString();
                String style = uow.table.GetByID(idForSub).MountStyle;
                listOfSub.Add(height);
                listOfSub.Add(length);
                listOfSub.Add(style);
                return listOfSub;
            }
            else
            {
                return null ;
            }
        }
    }
}
