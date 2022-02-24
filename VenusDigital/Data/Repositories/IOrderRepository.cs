﻿using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCore;
using Microsoft.EntityFrameworkCore;
using VenusDigital.Models;
using VenusDigital.Models.ViewModels;

namespace VenusDigital.Data.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderByUserId(int userId);
        OrderDetails GetOrderDetails(int orderId, int productId);
        void AddOrderDetails(OrderDetails orderDetail);
        void AddOrder(Order order);
        void SaveChanges();
        OrderDetails getOrderDetail(int detailId);
        void RemoveOrderDetail(OrderDetails detail);
    }

    public class OrderRepository : IOrderRepository
    {
        private VenusDigitalContext _context;

        public OrderRepository(VenusDigitalContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            _context.Order.Add(new Order()
            {
                CreateDate = order.CreateDate,
                IsFinally = order.IsFinally,
                UserId = order.UserId
            });
            _context.SaveChanges();
        }

        public void AddOrderDetails(OrderDetails orderDetail)
        {
            _context.OrderDetails.Add(new OrderDetails()
            {
                ProductId = orderDetail.ProductId,
                Count = orderDetail.Count,
                OrderId = orderDetail.OrderId
            });
            _context.SaveChanges();
        }

        public Order GetOrderByUserId(int userId)
        {
            return _context.Order
                .Where(o => o.UserId == userId && !o.IsFinally)
                .Include(o => o.OrderDetails)
                .ThenInclude(o => o.Product)
                .ThenInclude(p=>p.ProductGalleries)
                .FirstOrDefault();
        }

        public OrderDetails getOrderDetail(int detailId)
        {
            return _context.OrderDetails
                .Find(detailId);
        }

        public OrderDetails GetOrderDetails(int orderId, int productId)
        {
            return _context.OrderDetails
                .FirstOrDefault(d => d.OrderId == orderId && d.ProductId == productId);
        }

        public void RemoveOrderDetail(OrderDetails detail)
        {
            _context.OrderDetails
                .Remove(detail);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}