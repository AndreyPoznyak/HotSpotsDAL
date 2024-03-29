﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;

namespace HotSpotsConnectedLayer
{
    public static class HotSpotDAL
    {
        public static bool AddHotSpot(HotSpot obj)
        {
            bool success = false;
            using (var context = new HotSpotsDBEntities())
            {
                EntityKey key = new EntityKey("HotSpotsDBEntities.HotSpot", "bssid", obj.bssid);
                if ((HotSpot)context.GetObjectByKey(key) == null)
                {
                    context.AddToHotSpot(obj);
                    context.SaveChanges();
                    success = true;
                }
            }
            return success;
        }

        public static void DeleteHotSpot(String BssidToDelete)
        {
            HotSpot obj = new HotSpot();
            using (var context = new HotSpotsDBEntities())
            {
                EntityKey key = new EntityKey("HotSpotsDBEntities.HotSpot", "bssid", BssidToDelete);
                obj = (HotSpot)context.GetObjectByKey(key);
                if (obj != null)
                {
                    context.DeleteObject(obj);
                }
                context.SaveChanges();
            }
        }

        public static List<HotSpot> GetAllHotSpots()
        {
            List<HotSpot> list = new List<HotSpot>();
            using (var context = new HotSpotsDBEntities())
            {
                var ListOfHotSpots = from item in context.HotSpot select item;
                foreach(HotSpot hotsp in ListOfHotSpots)
                {
                    list.Add(hotsp);
                }
            }
            return list;
        }

        public static HotSpot GetHotSpot(String BssidToGet)
        {
            HotSpot obj = new HotSpot();
            using (var context = new HotSpotsDBEntities())
            {
                EntityKey key = new EntityKey("HotSpotsDBEntities.HotSpot", "bssid", BssidToGet);
                obj = (HotSpot)context.GetObjectByKey(key);
            }
            return obj;
        }
    }
}
