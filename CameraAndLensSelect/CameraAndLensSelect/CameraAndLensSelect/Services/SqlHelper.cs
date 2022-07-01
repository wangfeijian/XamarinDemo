using CameraAndLensSelect.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CameraAndLensSelect.Services
{
    public class SqlHelper
    {
        readonly SQLiteConnection _database;

        public SqlHelper()
        {
            _database = Xamarin.Forms.DependencyService.Get<ISQLite>().GetConnection();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <sql>sql语句</sql>
        /// <returns></returns>
        public  List<T> QueryData<T>(string sql, params object[] args) where T : new()
        {
            var datas =  _database.Query<T>(sql, args);

            return datas;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <sql>sql语句</sql>
        /// <returns></returns>
        //public async Task<List<LensData>> AsyncQueryLensData(string sql)
        //{
        //    var datas = await _database.QueryAsync<LensData>(sql);

        //    return datas;
        //}

    }
}
