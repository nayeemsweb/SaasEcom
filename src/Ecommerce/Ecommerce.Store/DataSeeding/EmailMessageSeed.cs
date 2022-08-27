using EmailMessageObj = Ecommerce.Store.Entities.EmailMessage;

namespace Ecommerce.Store.DataSeeding
{
    internal class EmailMessageSeed
    {
        internal EmailMessageObj[] EmailMessageSeeds
        {
            get
            {
                return new EmailMessageObj[]
                    {
                        new EmailMessageObj{Id=new Guid("4050A16E-35F4-4696-B1A5-93C3FCE68293"),
                            Subject="Email Confirmation", Message="Please confirm your account by <a href='https://localhost:7191/Account/ConfirmEmail?userId=97087166-d73e-45d9-fcb5-08da187a20f1&amp;code=Q2ZESjhLVFh6U0g2bHMxQ21JRlBxQjhUY1NjOWF3eFJWVldTWHBtd3VhNmtTNG8xcmo0NGVYVWxHY2VUbEplK1pIclJVUnlWZVhlTVh3NlpicVN5N1B2UTNTOVp5NGhJdWd5bzhWc3FjYUFtMm1hNk9JbjdPRzEveXZSYkFOdkVDU2RrbnZDa0dicHM0NWdUVk5raXZDczI3aVlzQWJHTFcwY1B0MVh2R2ZUdUZ1bURNd0wvMzhrdFNUa0JQdDVPaXM5T1IyWVJrbU8rem4wZWIyU1Z2WlpseDFEZGJobmowZ20xUXNEbE10U3JHdHhOdy80bFJsdkxUbWpCWVNJazR3MlN6QT09&amp;returnUrl=%2F'>clicking here</a>.",
                            ReceiverName = "Lamia", ReceiverEmail = "lamia@gmail.com", EmailStatus = (Entities.EmailStatus)1,
                            NotificationType = (Entities.NotificationType)2, SendTime = new DateTime(2022, 5, 20, 13, 45, 0),
                            StoreId = new Guid("691DE45C-E852-4B05-AD05-2EF411D77BE6"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},

                        new EmailMessageObj{Id=new Guid("4BD3BCFE-8084-49D6-8D04-50A4B59808F5"),
                            Subject="New Order Notification", Message="Please Check just Placed Order",
                            ReceiverName = "Nabila", ReceiverEmail = "nabila@gmail.com", EmailStatus = (Entities.EmailStatus)1,
                            NotificationType = (Entities.NotificationType)5, SendTime = new DateTime(2022, 5, 20, 14, 45, 0),
                            StoreId = new Guid("2FB18A16-24CF-49A3-9D81-1A6FA5AB92F8"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},

                        new EmailMessageObj{Id=new Guid("093E78D3-DF09-435A-834F-8B53A01B82FF"),
                            Subject="Product StockOut", Message="Dash Product is out of stock",
                            ReceiverName = "Rifat", ReceiverEmail = "rifat@gmail.com", EmailStatus = (Entities.EmailStatus)1,
                            NotificationType = (Entities.NotificationType)4, SendTime = new DateTime(2022, 5, 20, 15, 45, 0),
                            StoreId = new Guid("644DE43F-1762-466D-A251-FF3995FE43CA"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                    };
            }

        }
    }
}
