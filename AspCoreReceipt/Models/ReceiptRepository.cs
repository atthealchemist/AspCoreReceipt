using App.Backend.Enumerable;
using App.Backend.Interfaces;
using App.Backend.Models;
using System.Collections.Generic;
using System.Linq;

namespace App.Backend.Repository
{
    public class ReceiptRepository : ICRUDInterface<Receipt>
    {
        private List<Receipt> _receipts = new List<Receipt> {
            new Receipt
            {
                Id = 0,
                Title = "Змейка",
                Slug = "Змейка",
                Images = new List<Image> {
                new Image {
                            Url = "http://sekret-vkysa.ru/wp-content/uploads/2014/04/DSC_3954.jpg",
                            Caption = "блюдо змейка"
                        },
                        new Image {
                            Url = "https://cdn.maximonline.ru/57/48/a2/5748a2bfea242d437923051d9df2ab97/483x480_1_6313a2bbc2ed9f1e126acaea4c910fc7@483x480_0xac120005_8832035841527734440.jpg",
                            Caption = "вариация змейка 2"
                        }
                },
                CookingTime = new Duration
                {
                    Value = 1,
                    DurationUnit = DurationUnit.MINUTES
                },
                Ingredients = new List<Ingredient> {
                       new Ingredient {
                           Id = 0,
                           Title = "Майонез",
                           Slug = "Майонез",
                           Amount = new Amount {
                               Value = 10,
                               Unit = WeightUnit.MILLILITERS
                           }
                       },
                       new Ingredient {
                          Id = 1,
                          Title = "Чёрный перец (горошек)",
                          Slug = "Чёрный перец (горошек)",
                          Amount = new Amount {
                              Value = 2,
                              Unit = WeightUnit.PCS
                          }
                       }
                    },
                Description = "Универсальное блюдо для разнообразия студенческой жизни.",
                Steps = new List<Step> {
                        new Step {
                            Number = 1,
                            Description = "Берем майонез и выдавливаем змейку любой формы",
                            Id = 0,
                            Duration = new Duration {
                                Value = 30,
                                DurationUnit = DurationUnit.SECONDS
                            }
                        },
                        new Step {
                            Number = 2,
                            Description = "Украшаем змейку двумя горошками чёрного перца",
                            Id = 1,
                            Duration = new Duration
                            {
                                Value = 30,
                                DurationUnit = DurationUnit.SECONDS
                            }
                        }
                    }
            },
            new Receipt
            {
                Id = 1,
                Title = "Хлеб с маслом и солью",
                Slug = "Хлеб с маслом и солью",
                Images = new List<Image> {
                        new Image {
                            Url = "https://s00.yaplakal.com/pics/pics_original/4/8/5/7768584.jpg",
                            Caption = "хлеб"
                        }
                },
                CookingTime = new Duration
                {
                    Value = 3,
                    DurationUnit = DurationUnit.MINUTES
                },
                Ingredients = new List<Ingredient> {
                       new Ingredient {
                           Id = 2,
                           Title = "Чёрный хлеб",
                           Slug = "Чёрный хлеб",
                           Amount = new Amount {
                               Value = 1,
                               Unit = WeightUnit.PCS
                           }
                       },
                       new Ingredient {
                          Id = 3,
                          Title = "Масло",
                          Slug = "Масло",
                          Amount = new Amount {
                              Value = 50,
                              Unit = WeightUnit.MILLILITERS
                          }
                       },
                       new Ingredient {
                           Id = 4,
                           Title = "Соль",
                           Slug = "Соль",
                           Amount = new Amount {
                               Value = 10,
                               Unit = WeightUnit.GRAMS
                           }
                       }
                    },
                Description = "Вкусно и просто. Когда нет денег, а сдохнуть от голода не хочется.",
                Steps = new List<Step> {
                        new Step {
                            Number = 1,
                            Description = "Отрезаем кусок хлеба",
                            Id = 0,
                            Duration = new Duration
                            {
                                Value = 10,
                                DurationUnit = DurationUnit.SECONDS
                            }
                        },
                        new Step {
                            Number = 2,
                            Description = "Наливаем на него масло",
                            Id = 1,
                            Duration = new Duration
                            {
                                Value = 10,
                                DurationUnit = DurationUnit.SECONDS
                            }
                        },
                        new Step {
                            Number = 3,
                            Description = "Подождем, пока масло впитается. Размажем пальцем.",
                            Id = 2,
                            Duration = new Duration
                            {
                                Value = 10,
                                DurationUnit = DurationUnit.SECONDS
                            }
                        },
                        new Step {
                            Number = 4,
                            Description = "Насыпаем соль и втираем её в масло.",
                            Id = 3,
                            Duration = new Duration
                            {
                                Value = 10,
                                DurationUnit = DurationUnit.SECONDS
                            }
                        }
                    }
            }
        };

        public List<Receipt> All()
        {
            return _receipts;
        }

        public void Create(Receipt entity)
        {
            _receipts.Add(entity);
        }

        public void Delete(Receipt entity)
        {
            _receipts.Remove(entity);
        }

        public void Delete(int id)
        {
            _receipts.Remove(Get(id));
        }

        public Receipt Get(int id)
        {
            return _receipts.First(receipt => receipt.Id == id);
        }

        /// <summary>
        /// Updates receipt
        /// </summary>
        /// <param name="id">Id of old receipt</param>
        /// <param name="entity">New receipt instance</param>
        public void Update(int id, Receipt entity)
        {
            Delete(_receipts.First(receipt => receipt.Id == id));
            _receipts.Add(entity);
        }

    }
}
