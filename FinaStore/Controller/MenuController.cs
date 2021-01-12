﻿using FinaStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaStore.Controller
{
    class MenuController
    {
        private List<Item> menuItem;

        public MenuController()
        {
            menuItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.menuItem.Add(item);
        }

        public List<Item> getItems()
        {
            return this.menuItem;
        }
    }
}
