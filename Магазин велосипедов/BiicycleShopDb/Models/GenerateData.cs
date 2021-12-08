using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiicycleShopDb.Models
{
    public class GenerateData
    {
        public static void Initialize(BicycleContext context)
        {
            if(!context.Bicycle.Any())
            {
                context.Bicycle.AddRange(
                        new Bicycle
                        {
                            Title = "Cross Focus",
                            Wheel_Diameter = 26,
                            Class = "Хардтейл",
                            Clolor = "Красны",
                            Frame_Material = "Сталь",
                            Number_Speeds = 12,
                            Frame = "Сталь, Хардтейл",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/174538047.jpg",
                            Prise = 10000
                        },
                        new Bicycle
                        {
                            Title = "Dorozhnik Obsidian",
                            Wheel_Diameter = 28,
                            Class = "Городской",
                            Clolor = "Синий",
                            Frame_Material = "Сталь",
                            Number_Speeds = 1,
                            Frame = "Сталь",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/174538047.jpg",
                            Prise = 12000
                        },
                        new Bicycle
                        {
                            Title = "Formula Omega",
                            Wheel_Diameter = 26,
                            Class = "Городской",
                            Clolor = "КМС",
                            Frame_Material = "Карбон",
                            Number_Speeds = 16,
                            Frame = "Сталь",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/190976463.jpg",
                            Prise = 14000
                        },
                        new Bicycle
                        {
                            Title = "VNC FastRider",
                            Wheel_Diameter = 24,
                            Class = "Городской",
                            Clolor = "Черный",
                            Frame_Material = "Карбон",
                            Number_Speeds = 10,
                            Frame = "Сталь",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/189377572.jpg",
                            Prise = 10000
                        },
                        new Bicycle
                        {
                            Title = "VNC FastRider",
                            Wheel_Diameter = 24,
                            Class = "Городской",
                            Clolor = "Голубой",
                            Frame_Material = "Титан",
                            Number_Speeds = 1,
                            Frame = "Сталь",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/120324548.jpg",
                            Prise = 10000
                        },
                        new Bicycle
                        {
                            Title = "Merida Reacto Disc",
                            Wheel_Diameter = 28,
                            Class = "Шосейный",
                            Clolor = "Черный",
                            Frame_Material = "Карбон",
                            Number_Speeds = 21,
                            Frame = "Карбон",
                            Img_Url = "https://velotime.com.ua/wa-data/public/shop/products/32/55/5532/images/10161/10161.970.jpg",
                            Prise = 20000
                        },
                        new Bicycle
                        {
                            Title = "TRINX Tempo",
                            Wheel_Diameter = 28,
                            Class = "Ригид",
                            Clolor = "Голубой",
                            Frame_Material = "Карбон",
                            Number_Speeds = 21,
                            Frame = "Карбон",
                            Img_Url = "https://content2.rozetka.com.ua/goods/images/big/184623038.jpg",
                            Prise = 34000
                        },
                        new Bicycle
                        {
                            Title = "Ardis",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "Серый",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 18,
                            Frame = "Алюминий",
                            Img_Url = "https://content2.rozetka.com.ua/goods/images/big/185230278.jpg",
                            Prise = 15000
                        },
                        new Bicycle
                        {
                            Title = "Ardis Titan",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "КМС",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/190976469.jpg",
                            Prise = 18000
                        },
                        new Bicycle
                        {
                            Title = "Ardis Lido",
                            Wheel_Diameter = 26,
                            Class = "Городской Ригид",
                            Clolor = "Черный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 1,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/178278613.jpg",
                            Prise = 5000
                        },
                        new Bicycle
                        {
                            Title = "Dorozhnik LUX Velosteel",
                            Wheel_Diameter = 26,
                            Class = "Городской",
                            Clolor = "Сливовый",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 1,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/192102281.jpg",
                            Prise = 6000
                        },
                        new Bicycle
                        {
                            Title = "Atlantic Rekon",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "Черный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 24,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/179420402.jpg",
                            Prise = 12000 
                        },
                        new Bicycle
                        {
                            Title = "Royal Baby Chipmunk Explorer",
                            Wheel_Diameter = 20,
                            Class = "БМХ",
                            Clolor = "Синий",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 1,
                            Frame = "Алюминий",
                            Img_Url = "https://content2.rozetka.com.ua/goods/images/big/16461999.jpg",
                            Prise = 6500
                        },
                        new Bicycle
                        {
                            Title = "Royal Baby Chipmunk Explorer",
                            Wheel_Diameter = 24,
                            Class = "Горный",
                            Clolor = "Красный",
                            Frame_Material = "Сталь",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/132291527.jpg",
                            Prise = 7500
                        },
                        new Bicycle
                        {
                            Title = "Discovery FLIPPER AM DD",
                            Wheel_Diameter = 24,
                            Class = "Горный",
                            Clolor = "Синий",
                            Frame_Material = "Сталь",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/179842883.jpg",
                            Prise = 5500
                        },
                        new Bicycle
                        {
                            Title = "Dorozhnik CORAL",
                            Wheel_Diameter = 21,
                            Class = "Горный",
                            Clolor = "Бежевый",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 1,
                            Frame = "Алюминий",
                            Img_Url = "https://content2.rozetka.com.ua/goods/images/big_tile/192066550.jpg",
                            Prise = 9500
                        },
                        new Bicycle
                        {
                            Title = "Ardis Silver Bike",
                            Wheel_Diameter = 21,
                            Class = "Горный",
                            Clolor = "Черный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content2.rozetka.com.ua/goods/images/big/159678396.jpg",
                            Prise = 8500
                        },
                        new Bicycle
                        {
                            Title = "Orbea MX",
                            Wheel_Diameter = 27,
                            Class = "Горный",
                            Clolor = "Голубой",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/178463005.jpg",
                            Prise = 23500
                        },
                        new Bicycle
                        {
                            Title = "Formula Forest",
                            Wheel_Diameter = 24,
                            Class = "Горный",
                            Clolor = "Голубой",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/178463005.jpg",
                            Prise = 12000
                        },
                        new Bicycle
                        {
                            Title = "Orbea Carpe",
                            Wheel_Diameter = 28,
                            Class = "Шосейный",
                            Clolor = "Голубой",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content2.rozetka.com.ua/goods/images/big_tile/17599435.jpg",
                            Prise = 18000
                        },
                        new Bicycle
                        {
                            Title = "Dorozhnik RETRO Velosteel",
                            Wheel_Diameter = 28,
                            Class = "Городской",
                            Clolor = "серый",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 1,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/192122740.jpg",
                            Prise = 8000
                        },
                        new Bicycle
                        {
                            Title = "VNC Fighter",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "Черный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/196831426.jpg",
                            Prise = 10000
                        },
                        new Bicycle
                        {
                            Title = "Ardis Leopard",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "Черный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/113523390.jpg",
                            Prise = 11000
                        },
                        new Bicycle
                        {
                            Title = "Leon Junior AM",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "красный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content.rozetka.com.ua/goods/images/big/195147221.jpg",
                            Prise = 11000
                        },
                        new Bicycle
                        {
                            Title = "Ardis Hiland 21",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "красный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/174538047.jpg",
                            Prise = 11000
                        },
                        new Bicycle
                        {
                            Title = "Discovery Rider DD",
                            Wheel_Diameter = 26,
                            Class = "Горный",
                            Clolor = "красный",
                            Frame_Material = "Алюминий",
                            Number_Speeds = 21,
                            Frame = "Алюминий",
                            Img_Url = "https://content1.rozetka.com.ua/goods/images/big/174538047.jpg",
                            Prise = 7000
                        }
                    );
                context.SaveChanges();
            }
           
        }
    }
}
