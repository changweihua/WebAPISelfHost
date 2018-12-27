using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using Common;

namespace Host
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18052
     * 类 名 称:	ContactsController
     * 机器名称:	LUMIA800
     * 命名空间:	Host
     * 文 件 名:	ContactsController
     * 创建时间:	2014/2/9 15:34:03
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2014 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	430ea804-36fd-43c4-88e1-4a9ba1ca1cf6  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2014
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 摘要
    /// </summary>
    public class ContactsController  : ApiController
    {
        private static List<Contact> contacts = new List<Contact> {
            new Contact{ Id=1, Name="Changweihua", Email="changweihua@outlook.com"}  ,
            new Contact{ Id=2, Name="Changweihua", Email="changweihua@outlook.com"}
        };

        public IEnumerable<Contact> Get()
        {
            return contacts;
        }

    }
}
