using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace de1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategoryData();
            }
        }

        private void BindCategoryData()
        {
            // Lấy chuỗi kết nối từ Web.config
            string connStr = ConfigurationManager.ConnectionStrings["QLKhoaHocDatabase"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Truy vấn để lấy danh mục khóa học và số lượng khóa học tương ứng
                string query = @"SELECT c.CatID, c.CatName, COUNT(co.ID) AS CourseCount
                                 FROM Category c
                                 LEFT JOIN Course co ON c.CatID = co.CatID
                                 GROUP BY c.CatID, c.CatName";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // Kiểm tra và gán dữ liệu vào DataList
                if (reader.HasRows)
                {
                    dlCategories.DataSource = reader;
                    dlCategories.DataBind();
                }

                conn.Close();
            }
        }

        protected void dlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
