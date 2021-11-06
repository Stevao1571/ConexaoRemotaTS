using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace ConexaoRemotaTS
{
    public class ConectarTS
    {

        public void ConnectarUsuario(string usuario, string senha)
        {
            DescobrirTS desc = new DescobrirTS();


            Process ipconfigProcess = new Process();
            ipconfigProcess.StartInfo.FileName = "cmdkey";
            ipconfigProcess.StartInfo.Arguments = $"/generic:{desc.consultaservidor(usuario)} /user:Gondim\\{usuario} /pass:{senha}";
            ipconfigProcess.StartInfo.RedirectStandardOutput = true;
            ipconfigProcess.StartInfo.UseShellExecute = false;
            ipconfigProcess.Start();
            ipconfigProcess.StartInfo.FileName = "mstsc";
            ipconfigProcess.StartInfo.Arguments = $@"/v: {desc.consultaservidor(usuario)} ";
            //ipconfigProcess.StartInfo.RedirectStandardOutput = true;
            //ipconfigProcess.StartInfo.UseShellExecute = false;
            ipconfigProcess.Start();
            StreamReader reader = ipconfigProcess.StandardOutput;

        }



        public class UserInfo
        {
            public string Domain { get; set; }
            public string User { get; set; }



        }

    }
}
