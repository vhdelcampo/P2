// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// // using GoalDigger.Domain.Interfaces;
// using GoalDigger.Domain.Models;
// using GoalDigger.DataStore.Databases;
// using GoalDigger.Domain.Abstracts;

// namespace GoalDigger.DataStore.Repositories 
// {
//   public class FeedRepository : ARepository
//   {
//     public FeedRepository(){}

//     public List<FeedModel> Read() 
//     {
// 			return _db.Feeds.ToList();
//     }
//     public FeedModel Read(long uid)
//     {
//       return _db.Feeds.SingleOrDefault(x => x.uid == uid);
//     }
//     public FeedModel Read(UserModel user)  // get a user's feed
//     {
//       return _db.Feeds.SingleOrDefault(x => x.User.uid == user.uid);
//     }
//     public bool Create(FeedModel model) // add a new record to the DBMS
//     {
//       _db.Feeds.Update(model);
//       return _db.SaveChanges() == 1;
//     }
//     public bool Update(FeedModel model) // update an existing record
//     {
//       FeedModel x = Read(model.uid);
//       x = model;
//       return _db.SaveChanges() == 1;
//     }

//     // public List<Order> Get(User user)
//     // {
//     //   List<Order> list = (_db.Order.Where(o => o.UserId == user.UserId).ToList());
//     //   return list;
//     // }

//     // public List<Post> Get(long userId)
//     // {
//     //   List<Order> list = (_db.Order.Where(o => o.UserId == userId).ToList());
//     //   return list;
//     // }

//     // public List<Order> GetPeriod(Store store, double days)
//     // {
//     //   List<Order> list = (_db.Order.Where(o => o.StoreId == store.StoreId && o.Date.AddHours(days*24) >= DateTime.Now).ToList());
      
//     //   return list;
//     // }

//     // public List<Order> GetPeriod(User user, double days)
//     // {
//     //   List<Order> list = (_db.Order.Where(o => o.UserId == user.UserId && o.Date.AddHours(days*24) >= DateTime.Now).ToList());

//     //   return list;
//     // }

//     // public int Get2Hours(User user)
//     // {
//     //   List<Order> list = Get(user);
//     //   int count = 0;

//     //   foreach (var o in list)
//     //   {
//     //       double minutes = DateTime.Now.Subtract(o.Date).TotalMinutes;

//     //       if (minutes < 2*60)
//     //       {
//     //         count++;
//     //       }
//     //   }
//     //   return count;
//     // }

//     // public int Get24HoursAtStore(User user, Store store)
//     // {
//     //   List<Order> list = (_db.Order.Where(o => o.UserId == user.UserId && o.StoreId != store.StoreId).ToList());
//     //   int count = 0;
//     //   foreach (var o in list)
//     //   {
//     //       double minutes = DateTime.Now.Subtract(o.Date).TotalMinutes;

//     //       if (minutes < 24*60)
//     //       {
//     //         count++;
//     //       }
//     //   }
//     //   return count;
//     // }

//     // public bool Post(Order order)
//     // {
//     //   _db.Order.Add(order);
//     //   return _db.SaveChanges() == 1;
//     // }

//     // public bool HasItBeenMoreThan2Hours(User user)
//     // {
//     //   bool check = true;
//     //   List<Order> list = Get(user);
//     //   foreach (var o in list)
//     //   {
        
//     //     DateTime date = DateTime.Now;
//     //     double minutes = date.Subtract(o.Date).TotalMinutes;

//     //     if (minutes < 2*60)
//     //     {
//     //       check = false;
//     //     }
//     //   }
//     //   return check;
//     // } 

//     // public bool HasItBeenMoreThan24Hours(User user, Store store)
//     // {
//     //   bool check = true;
//     //   List<Order> list = Get(user);
//     //   if (list.Count() > 0)
//     //   {
//     //     int count = Get24HoursAtStore(user, store);
//     //     if (count > 0)
//     //     {
//     //       check = false;
//     //     }
//     //   }
//     //   return check;
//     // }

//   }
// }
