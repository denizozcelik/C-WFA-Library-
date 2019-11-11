using Project.BLL.RepositoryPattern.RepositoryClasses;
using Project.DAL.MyContext;
using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ListMethod()
        {
            dataGridView1.DataSource = br.SelectAll().Where(x => x.CategoryID != null).Select(
              x => new
              {
                  KitapID = x.ID,
                  KitapIsmi = x.Title,
                  KategoriIsmi = x.Category.CategoryName,
                  KategoriID = x.CategoryID,
                  YazarID = x.AuthorID,
                  YazarIsmi = x.Author.FirstName
              }

            ).ToList();
        }
        private void BookList()
        {
            dataGridView1.DataSource = br.SelectAll();
        }
        private void CategoryList()
        {
            dataGridView1.DataSource = cr.SelectAll();
        }
        private void AuthorList()
        {
            dataGridView1.DataSource = ar.SelectAll();
        }
        private void CategoryCombo()
        {
            cmbKategori.DataSource = cr.SelectAll();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "ID";
        }
        private void AuthorCombo()
        {
            cmbYazar.DataSource = ar.SelectAll();
            cmbYazar.DisplayMember = "FirstName";
            cmbYazar.ValueMember = "ID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AuthorCombo();
            CategoryCombo();
            ListMethod();
        }

        BookRepository br = new BookRepository();
        AuthorRepository ar = new AuthorRepository();
        CategoryRepository cr = new CategoryRepository();

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.CategoryName = txtKategoriAdi.Text;
            cr.Add(c);
            CategoryList();
            CategoryCombo();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            cr.SpecialDelete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            CategoryList();
            CategoryCombo();

        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            Category guncellenecek = cr.GetByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            guncellenecek.CategoryName = txtKategoriAdi.Text;
            cr.Update(guncellenecek);
            CategoryList();
            CategoryCombo();

        }

        private void btnKategroiListele_Click(object sender, EventArgs e)
        {
            CategoryList();
        }


        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            br.SpecialDelete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            BookList();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Title = txtKitapAdi.Text;
            b.CategoryID = Convert.ToInt32(cmbKategori.SelectedValue);
            b.AuthorID = Convert.ToInt32(cmbYazar.SelectedValue);
            br.Add(b);
            BookList();
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            Book guncellenecek = br.GetByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            guncellenecek.Title = txtKitapAdi.Text;
            guncellenecek.AuthorID = Convert.ToInt32(cmbYazar.SelectedValue);
            guncellenecek.CategoryID = Convert.ToInt32(cmbKategori.SelectedValue); ;
            br.Update(guncellenecek);
            BookList();
        }
        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            BookList();
        }
        
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.FirstName = txtYazarAdi.Text;
            a.LastName = txtYazarSoyad.Text;
            ar.Add(a);
            AuthorList();
            AuthorCombo();
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            ar.SpecialDelete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            AuthorList();
            AuthorCombo();
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            Author guncellenecek = ar.GetByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            guncellenecek.FirstName = txtYazarAdi.Text;
            guncellenecek.LastName = txtYazarSoyad.Text;
            ar.Update(guncellenecek);
            AuthorList();
            AuthorCombo();
        }

        private void btnYazarListele_Click(object sender, EventArgs e)
        {
            AuthorList();
        }

        SContext db = SContext.DBInstance;
        Book bi = new Book();
        Category ci = new Category();
        Author ai = new Author();

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            var kitapBul = from bi in db.Kitaplar.Where(x => x.Title.Contains(txtKitapAra.Text))
                           select new
                           {
                               KitapAdi = bi.Title,
                               KategoriIsmi = bi.Category.CategoryName,
                               YazarAdı = bi.Author.FirstName
                           };
            dataGridView1.DataSource = kitapBul.ToList();

        }

        private void btnKategoriAdiAra_Click(object sender, EventArgs e)
        {
            var kategoriAra = from bi in db.Kitaplar
                              join ai in db.Yazarlar
                              on bi.AuthorID equals ai.ID
                              join ci in db.Kategoriler.Where(x => x.CategoryName.Contains(txtKategoriAra.Text)) on bi.CategoryID equals ci.ID
                              select new
                              {
                                  KitapAdı = bi.Title,
                                  KategoriAdı = ci.CategoryName,
                                  YazarAdı = ai.FirstName,
                                  YazarSoyadı = ai.LastName
                              };
            dataGridView1.DataSource = kategoriAra.ToList();
        }

        private void btnYazarAdiAra_Click(object sender, EventArgs e)
        {
            var yazarAra = from bi in db.Kitaplar
                           join ci in db.Kategoriler on bi.CategoryID equals ci.ID
                           join ai in db.Yazarlar.Where(x => x.FirstName.Contains(txtYazarAra.Text)) on bi.AuthorID equals ai.ID
                           select new
                           {
                               KitapAdı = bi.Title,
                               KategoriAdı = ci.CategoryName,
                               YazarAdı = ai.FirstName,
                               YazarSoyadı = ai.LastName
                           };
            dataGridView1.DataSource = yazarAra.ToList();
        }

        private void btnGenelListeleme_Click(object sender, EventArgs e)
        {
            ListMethod();
        }
    }
}
