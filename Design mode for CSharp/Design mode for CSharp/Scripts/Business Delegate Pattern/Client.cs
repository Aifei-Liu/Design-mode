﻿/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Business_Delegate_Pattern
{
    public class Client
    {
        private BusinessDelegate businessService;

        public Client(BusinessDelegate businessService)
        {
            this.businessService = businessService;
        }

        public void doTask()
        {
            businessService.doTask();
        }
    }
}