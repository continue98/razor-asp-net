﻿using System.Web;
using NHibernate.Cfg;
using NHibernate;

namespace MvcApplication1
{
    public class NHibernateSessionManeger
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var users_conf_file = HttpContext.Current.Server.MapPath(@"~\Mappings\Users.hbm.xml");
            configuration.AddFile(users_conf_file);
            var doc_conf_file = HttpContext.Current.Server.MapPath(@"~\Mappings\Doc.hbm.xml");
            configuration.AddFile(doc_conf_file);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}