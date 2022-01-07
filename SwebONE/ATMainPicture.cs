﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwebONE
{
    class ATMainPicture
    {  /// <summary>
       /// 对每个行项进行匹配，显示正确的图片信息
       /// </summary>
       /// <param name="ListView"></param>
        public static void getPictures(DataTable table)
        {
            foreach (DataRow Row in table.Rows)
            {
                //已经过了签到时间的行项中，自动签到，并显示黑白图片
                if (Row["Info"].ToString() == "未开始" || Row["Info"].ToString() == "未签到" || Row["Info"].ToString() == "未签退")
                {
                    switch (Row["Picture"].ToString())
                    {
                        case "shangban1":
                            Row["Picture"] = "shangban2.png";
                            break;
                        case "xiaban1":
                            Row["Picture"] = "xiaban2.png";
                            break;
                        case "gongzuozhong1":
                            Row["Picture"] = "gongzuozhong2.png";
                            break;
                    }
                }
                if (string.IsNullOrEmpty(Row["Action"].ToString()) == false)           //正等待签到的行项中，显示彩色图片
                {
                    switch (Row["Picture"].ToString())
                    {
                        case "shangban2":
                            Row["Picture"] = "shangban1.png";
                            break;
                        case "xiaban2":
                            Row["Picture"] = "xiaban1.png";
                            break;
                        case "gongzuozhong2":
                            Row["Picture"] = "gongzuozhong1.png";
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// 签到情况下，将已签到行项图片显示黑白
        /// </summary>
        /// <param name="ListView"></param>
        /// <param name="i"></param>
        public static void BlackWhite(DataTable table, int i)            //签到页面
        {
            switch (table.Rows[i]["Picture"].ToString())    //已经签到的行项中，图片显示黑白
            {
                case "shangban1":
                    table.Rows[i]["Picture"] = "shangban2.png";
                    break;
                case "xiaban1":
                    table.Rows[i]["Picture"] = "xiaban2.png";
                    break;
                case "gongzuozhong1":
                    table.Rows[i]["Picture"] = "gongzuozhong2.png";
                    break;
            }
        }

        /// <summary>
        /// 查看统计时候，将全部行项图片显示黑白
        /// </summary>
        /// <param name="ListView"></param>
        public static void AllBlackWhite(DataTable table)     //查看页面
        {
            foreach (DataRow Row in table.Rows)         //签到状态下，将图片显示为黑白
            {
                switch (Row["Picture"].ToString())
                {
                    case "shangban1":
                        Row["Picture"] = "shangban2.png";
                        break;
                    case "xiaban1":
                        Row["Picture"] = "xiaban2.png";
                        break;
                    case "gongzuozhong1":
                        Row["Picture"] = "gongzuozhong2.png";
                        break;
                }
            }
        }
    }
}
