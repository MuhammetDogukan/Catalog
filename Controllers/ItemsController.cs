using System;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controller
{
    [ApiController]
    [Route("items")]
    public class ItemsController: ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository=new InMemItemsRepository();
        }
        //Get /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
        //Get/items/{id}
        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            return item;
        }
    }
}