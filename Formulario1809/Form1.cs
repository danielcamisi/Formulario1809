using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace Formulario1809
{
    public partial class Form1 : Form
    {
        string dbPath = @"D:\daniel\db\Contatos.db";
        //string dbPath = @"C:\Users\daniel.csilva66\Documents\Contato.db";

        string connectString;

        public Form1()
        {
            InitializeComponent();

            //String de conexão
            connectString = $"Data Source={dbPath};Version=3;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void TestarConexao()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();
                    MessageBox.Show("Conexão OK!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro, Tudo errado!: {ex.Message}");
            }
        }


        private void Consultar_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }
        //Metodo de consulta//
        private void ConsultarClientes()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM clientes";

                    using (var grid = new SQLiteDataAdapter(sql, connection))
                    {
                        DataTable dt = new DataTable(); //cria o Data table
                        grid.Fill(dt); //preenche o data table
                        dataGridView1.DataSource = dt; //atribui o data table ao data grid view
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Consultar!: {ex.Message}");
            }
        }
        //Fecha o Banco de dados e encerra a aplicação//
        private void Sair_Click(object sender, EventArgs e)
        {

            if(Sair.Text == "Sair")
            {
                this.Close();
            }
            else
            {
                Sair.Text = "Sair";
                Incluir.Text = "Incluir";
                Consultar.Enabled = true;
                Excluir.Enabled = true;
                MessageBox.Show("Você saiu da Edição de Usuários");
                LimparCampos();
            }
         
        }

        private void Incluir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("O campo Nome do Cliente é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("O campo Telefone é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPhone.Focus();
                return;
            }

            if (!UmAno.Checked && !SeisMeses.Checked && !TresMeses.Checked)
            {
                MessageBox.Show("Selecione uma opção para Cliente VIP.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma opção para Prospect.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }


            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    if (Incluir.Text == "Salvar" && codigoClienteSelecionado != -1)
                    {
                        string sqlUpdate = @"UPDATE clientes SET 
                                               NomeCliente=@NomeCliente,
                                               Telefone=@Telefone,
                                               Local=@Local,
                                               ClienteVip=@ClienteVip,
                                               DataCadastro=@DataCadastro,
                                               Prospect=@Prospect
                                               WHERE CodigoCliente=@CodigoCliente";

                        using(var cmd = new SQLiteCommand(sqlUpdate, connection))
                        {
                            cmd.Parameters.AddWithValue("@NomeCliente", TxtName.Text);
                            cmd.Parameters.AddWithValue("@Telefone", TxtPhone.Text);

                            string local = Interno.Checked ? "Interno" : "Externo";
                            cmd.Parameters.AddWithValue("@Local", local);

                            int vip = 0;

                            if (UmAno.Checked) vip = 1;
                            else if (SeisMeses.Checked) vip = 2;
                            else if (TresMeses.Checked) vip = 3;
                            cmd.Parameters.AddWithValue("@ClienteVip", vip);

                            cmd.Parameters.AddWithValue("@DataCadastro", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                            cmd.Parameters.AddWithValue("@Prospect", comboBox1.Text);

                            cmd.Parameters.AddWithValue("@CodigoCliente", Txt_User.Text);

                            cmd.ExecuteNonQuery();
                        }
                        Incluir.Text = "Incluir";
                        codigoClienteSelecionado = -1;
                        Sair.Text = "Sair";

                        Consultar.Enabled = true;
                        Excluir.Enabled = true;
                    }
                    else
                    {



                        string sql = @"INSERT INTO clientes 
                        ( NomeCliente, Telefone, Local, ClienteVip, DataCadastro, Prospect)
                        VALUES 
                        ( @NomeCliente, @Telefone, @Local, @ClienteVip, @DataCadastro, @Prospect)";
                        using (var cmd = new SQLiteCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@NomeCliente", TxtName.Text);
                            cmd.Parameters.AddWithValue("@Telefone", TxtPhone.Text);

                            string local = Interno.Checked ? "Interno" : "Externo";
                            cmd.Parameters.AddWithValue("@Local", local);

                            int vip = 0;

                            if (UmAno.Checked) vip = 1;
                            else if (SeisMeses.Checked) vip = 2;
                            else if (TresMeses.Checked) vip = 3;
                            cmd.Parameters.AddWithValue("@ClienteVip", vip);

                            cmd.Parameters.AddWithValue("@DataCadastro", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                            cmd.Parameters.AddWithValue("@Prospect", comboBox1.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente Incluído com Sucesso!");
                    ConsultarClientes();
                    LimparCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Incluir!: {ex.Message}");
                Incluir.Text = "Incluir";

                Sair.Text = "Sair";
            }
        }
        private void LimparCampos()
        {
            TxtName.Clear();
            Txt_User.Clear();
            TxtPhone.Clear();

            Interno.Checked = true;

            UmAno.Checked = false;
            SeisMeses.Checked = false;
            TresMeses.Checked = false;

            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
        }

        private void UmAno_CheckedChanged(object sender, EventArgs e)
        {
            if (UmAno.Checked)
            {

                SeisMeses.Checked = false;
                TresMeses.Checked = false;

                SeisMeses.Enabled = false;
                TresMeses.Enabled = false;
            }
            else
            {
                SeisMeses.Enabled = true;
                TresMeses.Enabled = true;
            }
        }

        private void SeisMeses_CheckedChanged(object sender, EventArgs e)
        {

            if (SeisMeses.Checked)
            {
                UmAno.Checked = false;
                TresMeses.Checked = false;

                UmAno.Enabled = false;
                TresMeses.Enabled = false;
            }
            else
            {
                UmAno.Enabled = true;
                TresMeses.Enabled = true;
            }

        }

        private void TresMeses_CheckedChanged(object sender, EventArgs e)
        {
            if (TresMeses.Checked)
            {
                UmAno.Checked = false;
                SeisMeses.Checked = false;

                UmAno.Enabled = false;
                SeisMeses.Enabled = false;
            }
            else
            {
                UmAno.Enabled = true;
                SeisMeses.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show(
                $"Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            int codigoCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CodigoCliente"].Value);

            DialogResult result = MessageBox.Show(
               $"Deseja realmente Excluir o Cliente?", "Confirmação",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );

            if (result == DialogResult.No)
                return;
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sql = "DELETE FROM clientes WHERE CodigoCliente = @CodigoCliente";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cliente excluído com Sucesso!");

                    ConsultarClientes();
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show($"Houve um erro na exclusão!: {ex.Message}");
                }



            }
        }

        private int codigoClienteSelecionado = -1;

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            codigoClienteSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CodigoCliente"].Value);

            Txt_User.Text = dataGridView1.CurrentRow.Cells["CodigoCliente"].Value.ToString();
            TxtName.Text = dataGridView1.CurrentRow.Cells["NomeCliente"].Value.ToString();
            TxtPhone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();

            string local = dataGridView1.CurrentRow.Cells["Local"].Value.ToString();
            Interno.Checked = local == "Interno";
            Externo.Checked = local == "Externo";

            int vip = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClienteVip"].Value);
            UmAno.Checked = vip == 1;
            SeisMeses.Checked = vip == 2;
            TresMeses.Checked = vip == 3;

            comboBox1.Text = dataGridView1.CurrentRow.Cells["Prospect"].Value.ToString();

            Incluir.Text = "Salvar";

            Sair.Text = "Cancelar";

            Consultar.Enabled = false;
            Excluir.Enabled = false;
 

        }
    }
}
