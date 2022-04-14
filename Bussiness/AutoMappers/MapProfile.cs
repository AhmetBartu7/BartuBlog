using AutoMapper;
using Entities.DtoTable;
using Entities.EntityTable;

namespace Bussiness.AutoMappers
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {

            #region Blog



            CreateMap<Blogs, DtoBlogs>();
            CreateMap<DtoBlogs, Blogs>();

            CreateMap<Blogs, DtoBlogsSingle>();
            CreateMap<DtoBlogsSingle, Blogs>();

            CreateMap<Blogs, DtoBlogsMulti>();
            CreateMap<DtoBlogsMulti, Blogs>();


            #endregion


            #region BlogComments

            CreateMap<BlogComments, DtoBlogsComments>();
            CreateMap<DtoBlogsComments, BlogComments>();

            CreateMap<BlogComments, DtoBlogsCommentsList>();
            CreateMap<DtoBlogsCommentsList, BlogComments>();



            #endregion


            #region ReadTable


            CreateMap<ReadTables, DtoReadTables>();
            CreateMap<DtoReadTables, ReadTables>();

            CreateMap<ReadTables, DtoReadTablesList>();
            CreateMap<DtoReadTablesList, ReadTables>();


            #endregion


            #region MyAccounts


            CreateMap<MyAccounts, DtoMyAccounts>();
            CreateMap<DtoMyAccounts, MyAccounts>();

            CreateMap<MyAccounts, DtoMyAccountsList>();
            CreateMap<DtoMyAccountsList, MyAccounts>();

            #endregion



        }
    }
}
