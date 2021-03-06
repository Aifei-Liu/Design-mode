﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_mode_for_CSharp.Scripts.Abstract_Factory_Pattern;

public class AbstractFactoryDemo
{
    public void Test()
    {
        //获取形状工厂
        AbstractFactory shapeFactory = FactoryProducer.getFactory<ShapeFactory>();

        //获取形状为 Circle 的对象
        Shape shape1 = shapeFactory.getShape<Circle>();

        //调用 Circle 的 draw 方法
        shape1.draw();

        //获取形状为 Rectangle 的对象
        Shape shape2 = shapeFactory.getShape<Rectangle>();

        //调用 Rectangle 的 draw 方法
        shape2.draw();

        //获取形状为 Square 的对象
        Shape shape3 = shapeFactory.getShape<Square>();

        //调用 Square 的 draw 方法
        shape3.draw();

        //获取颜色工厂
        AbstractFactory colorFactory = FactoryProducer.getFactory<ColorFactory>();

        //获取颜色为 Red 的对象
        Color color1 = colorFactory.getColor<Red>();

        //调用 Red 的 fill 方法
        color1.fill();

        //获取颜色为 Green 的对象
        Color color2 = colorFactory.getColor<Green>();

        //调用 Green 的 fill 方法
        color2.fill();

        //获取颜色为 Blue 的对象
        Color color3 = colorFactory.getColor<Blue>();

        //调用 Blue 的 fill 方法
        color3.fill();
    }
}
