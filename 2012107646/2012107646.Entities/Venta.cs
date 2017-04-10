using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646.Entities
{
    public class Venta
    {
        public List<string> _ventas = new List<string>();

        string cabecera = "[Numero]\t[Tipo Plan]\t[Tipo Evaluacion]\t[Estado Evaluacion]\t[Cliente]";
        
       

        //tP= tipoPlan , tE= tipoEvaluacion, eE= estadoEvaluacion

        TipoPlan _tp = new TipoPlan();
        TipoEvaluacion _tE = new TipoEvaluacion();
        EstadoEvaluacion _eE = new EstadoEvaluacion();


        
        public void Agregar(string numero, int tP, int tE,int eE ,string cliente) 
        {
            try
            {
               
                if (tP == 1)
                {
                    Console.WriteLine("Se agrego el numero :" + numero + " al cliente :" + cliente);
                    Console.WriteLine("Tipo de plan :" + _tp.tipoPlan1);

                    string nuevoPrep = "";
                    nuevoPrep += numero.ToString();
                    nuevoPrep += "\t" + _tp.tipoPlan1.ToString();
                    nuevoPrep += "\t\t-";
                    nuevoPrep += "\t\t\t-";
                    nuevoPrep += "\t\t\t" + cliente.ToString();
 
                    _ventas.Add(nuevoPrep);
                    
                   
                }

                if (tP == 2)
                {
                    string nuevoPost = "";
                    switch (tE)
                    {
                        case 1:
                            if (eE == 1)
                            {
                                _ventas.Add(cabecera);
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoPlan2.ToString();
                                nuevoPost += "\t" +_tE.tipoEvaluacion1.ToString();
                                nuevoPost += "\t" +_eE.estado1.ToString();
                                nuevoPost += "\t\t" + cliente.ToString();
                            }
                            else if (eE == 2) 
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoPlan2.ToString();
                                nuevoPost += "\t" + _tE.tipoEvaluacion1.ToString();
                                nuevoPost += "\t" + _eE.estado2.ToString();
                                nuevoPost += "\t\t" + cliente.ToString();
                            }
                            _ventas.Add(nuevoPost);
                            break;
                        case 2:
                            if (eE == 1)
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoPlan2.ToString();
                                nuevoPost += "\t" + _tE.tipoEvaluacion2.ToString();
                                nuevoPost += "\t\t" + _eE.estado1.ToString();
                                nuevoPost += "\t\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            else if (eE == 2)
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoPlan2.ToString();
                                nuevoPost += "\t" + _tE.tipoEvaluacion2.ToString();
                                nuevoPost += "\t\t" + _eE.estado2.ToString();
                                nuevoPost += "\t\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            break;
                        case 3:
                            if (eE == 1)
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoPlan2.ToString();
                                nuevoPost += "\t" + _tE.tipoEvaluacion3.ToString();
                                nuevoPost += "\t\t" + _eE.estado1.ToString();
                                nuevoPost += "\t\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            else if (eE == 2)
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoPlan2.ToString();
                                nuevoPost += "\t" + _tE.tipoEvaluacion3.ToString();
                                nuevoPost += "\t\t" + _eE.estado2.ToString();
                                nuevoPost += "\t\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            break;
                        
                    }
                    Console.WriteLine("Se agrego el numero :" + numero + " al cliente :" + cliente);
                    Console.WriteLine("Tipo de plan :" + _tp.tipoPlan2);

                }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
                    
        }




 }
}
