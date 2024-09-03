using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //adiciona o conteudo das textbox a colunas
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            //limpa a caixa de texto
            txtNome.Clear();
            txtCurso.Clear();

            MessageBox.Show("Aluno Incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //exibe na label o contador de linhas do gridview atualizado
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //veririca a existencia de linahs no grid
            if (dgvAlunos.RowCount > 0)
            {
                //remove a linha selecionada no grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                //exibe uma mensagem ao usuario 
                MessageBox.Show("Aluno excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Exibe na label o total atualizado apos remoção
                lblTotal.Text = dgvAlunos.RowCount.ToString();
                

            }
                
                
                
        }
        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica a existencia de linhas no Grid
            if (dgvAlunos.RowCount > 0)
            {
                //Move o conteudo na primeira celula da linha selecionada para a textbox
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString(); //pega a posição da celula
                //txtAlteracao.Text = dgvAlunos.CurrentRow.Cells["colnome"].Value.ToString(); //pega a celula pelo nome

            }

        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "" )
            {
                //Move o novo valor da caixa de texto para a celula
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text; //vai pela posiçaõ da celula
                //dgvAlunos.CurrentRow.Cells["colnome"].Value = txtAlteracao.Text; //vai pelo nome da celula
                //exibe mensagem de alteração com sucesso
                MessageBox.Show("Aluno alterado com sucesso", "Exclusão", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //zera as linhas do grid, removendo as existentes
            dgvAlunos.RowCount = 0;

            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
