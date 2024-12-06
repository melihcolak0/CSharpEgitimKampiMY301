using CSharpEgitimKampiMY301.BusinessLayer.Abstract;
using CSharpEgitimKampiMY301.BusinessLayer.Concrete;
using CSharpEgitimKampiMY301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampiMY301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampiMY301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        //public FrmCategory()
        //{
        //    InitializeComponent();
        //}

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            bool categoryStatus = rdbActive.Checked;
            category.CategoryStatus = categoryStatus;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            bool categoryStatus = rdbActive.Checked;
            updatedValue.CategoryStatus = categoryStatus;
            _categoryService.TUpdate(updatedValue);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            //var values = _categoryService.TGetById(id);
            //dataGridView1.DataSource = values;
            var category = _categoryService.TGetById(id);            
            dataGridView1.DataSource = new List<Category> { category };
        }        
    }
}
