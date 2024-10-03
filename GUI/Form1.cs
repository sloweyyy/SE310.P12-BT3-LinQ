using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            panel2.Paint += panel2_Paint;
            panel3.Paint += panel3_Paint;
            panel4.Paint += panel4_Paint;
            panel5.Paint += panel5_Paint;
            panel6.Paint += panel6_Paint;
            panel7.Paint += panel7_Paint;
            panel8.Paint += panel8_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 20;
            var pnl = sender as Panel;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

            using (var pen = new Pen(Color.LightBlue, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(txbProductID.Text, out productId))
            {
                MessageBox.Show("Mã sản phẩm phải là số nguyên.");
                return;
            }

            int quantity;
            if (!int.TryParse(txbQuantity.Text, out quantity))
            {
                MessageBox.Show("Số lượng phải là số nguyên.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txbPrice.Text, out price))
            {
                MessageBox.Show("Đơn giá phải là số thập phân.");
                return;
            }

            var sp = new ProductDTO
            {
                ProductId = productId,
                ProductName = txbProductName.Text,
                Quantity = quantity,
                Price = price,
                Origin = txbOrigin.Text,
                ExpiryDate = dtpExpiryDate.Value
            };

            var bll = new ProductBLL();

            if (bll.CheckIfProductCodeExists(productId))
            {
                var result = MessageBox.Show("Mã sản phẩm đã tồn tại, bạn có muốn chỉnh sửa?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    bll.EditProduct(sp);
                else
                    return;
            }
            else
            {
                bll.AddProduct(sp);
            }

            dataGridView2.DataSource = bll.GetProductList();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var ProductId = int.Parse(dataGridView2.SelectedRows[0].Cells["ProductId"].Value.ToString());

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var bll = new ProductBLL();
                    bll.DeleteProduct(ProductId);

                    dataGridView2.DataSource = bll.GetProductList();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }


        private void btnHighestPrice_Click(object sender, EventArgs e)
        {
            var bll = new ProductBLL();
            dataGridView1.DataSource = bll.FindProductWithHighestPrice();
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            var bll = new ProductBLL();
            dataGridView1.DataSource = bll.FindProductsFromJapan();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StartPrice.Text) || string.IsNullOrEmpty(EndPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập cả giá trị bắt đầu và kết thúc.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal startPrice;
            decimal endPrice;

            if (!decimal.TryParse(StartPrice.Text, out startPrice))
            {
                MessageBox.Show("Giá trị bắt đầu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(EndPrice.Text, out endPrice))
            {
                MessageBox.Show("Giá trị kết thúc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startPrice > endPrice)
            {
                MessageBox.Show("Giá trị bắt đầu không được lớn hơn giá trị kết thúc.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var bll = new ProductBLL();
            dataGridView1.DataSource = bll.GetProductsInPriceRange(startPrice, endPrice);
        }


        private void btnExpiryDate_Click(object sender, EventArgs e)
        {
            var bll = new ProductBLL();
            dataGridView1.DataSource = bll.GetExpiredProductList();
        }

        private void btnDeleteOrigin_Click(object sender, EventArgs e)
        {
            var origin = txbFilterOrigin.Text;

            var bll = new ProductBLL();
            var dt = bll.GetProductList();

            foreach (DataRow row in dt.Rows)
                if (row["Origin"].ToString() == origin)
                    bll.DeleteProduct((int)row["ProductId"]);

            dataGridView2.DataSource = bll.GetProductList();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var bll = new ProductBLL();
            var dt = bll.GetProductList();

            foreach (DataRow row in dt.Rows) bll.DeleteProduct((int)row["ProductId"]);

            dataGridView2.DataSource = bll.GetProductList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bll = new ProductBLL();
            var dt = bll.GetProductList();
            dataGridView2.DataSource = bll.GetProductList();
        }

        private void btnCheckDate_Click(object sender, EventArgs e)
        {
            var bll = new ProductBLL();

            var sanPhamQuaHan = bll.GetExpiredProductList();

            var soLuongSanPhamQuaHan = sanPhamQuaHan.Rows.Count;

            MessageBox.Show($"Có {soLuongSanPhamQuaHan} sản phẩm đã quá hạn.", "Kiểm tra hạn sử dụng",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteAllDate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả các sản phẩm quá hạn?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var bll = new ProductBLL();
                bll.DeleteExpiredProduct();

                dataGridView2.DataSource = bll.GetProductList();

                MessageBox.Show("Tất cả các sản phẩm quá hạn đã được xóa.", "Xóa thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}