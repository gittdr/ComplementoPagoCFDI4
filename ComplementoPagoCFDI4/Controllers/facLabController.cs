using ComplementoPagoCFDI4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplementoPagoCFDI4.Controllers
{
    public class facLabController : Controller
    {
        // GET: FacCp
        public ModelosFact modelFact = new ModelosFact();

        public DataTable facturas()
        {
            return this.modelFact.getFacturas();
        }
        public DataTable billtoFp()
        {
            return this.modelFact.billtoFp();
        }
        public DataTable billtoPapelera()
        {
            return this.modelFact.billtoPapelera();
        }
        public DataTable tipoCambio()
        {
            return this.modelFact.tipoCambio();
        }
        public DataTable getCartasPorte(string factura)
        {
            return this.modelFact.getCartasPorte(factura);
        }
        public DataTable getTipoCambio(string fecha)
        {
            return this.modelFact.getTipoCambio(fecha);
        }
        public void Elist(string identificador)
        {
            this.modelFact.Elist(identificador);
        }
        public void IFpago(string billto)
        {
            this.modelFact.IFpago(billto);
        }
        public void IFpagoDelete(string idnum)
        {
            this.modelFact.IFpagoDelete(idnum);
        }
        public void IFpagoDeletePapelera(string idnum)
        {
            this.modelFact.IFpagoDeletePapelera(idnum);
        }
        public DataTable facturasClientes()
        {
            return this.modelFact.getFacturasClientes();
        }
        public DataTable FacturasPorProcesar(string billto)
        {
            return this.modelFact.getFacturasPorProcesar(billto);
        }
        public DataTable facturasEnviadas()
        {
            return this.modelFact.getFacturasEnviadas();
        }
        public DataTable facturasListadop()
        {
            return this.modelFact.getFacturasListadop();
        }
        //public DataTable facturasListado()
        //{
        //    return this.modelFact.getFacturasListado();
        //}
        public DataTable getBillto(string billto)
        {
            return this.modelFact.getBillto(billto);
        }
        public DataTable getnBillto(string billto)
        {
            return this.modelFact.getnBillto(billto);
        }
        public DataTable detalleFacturas(string fact, string IdRecep)
        {
            return this.modelFact.getDatosFacturas(fact, IdRecep);
        }
        public DataTable detalleFacturasV(string fact, string IdRecep)
        {
            return this.modelFact.getDatosFacturasV(fact, IdRecep);
        }
        public DataTable getDatosCPAGDOCTRL(string identificador, string foliocpag)
        {
            return this.modelFact.getDatosCPAGDOCTRL(identificador, foliocpag);
        }

        public DataTable getDatosCPAGDOC(string identificador, string IdRecep)
        {
            return this.modelFact.getDatosCPAGDOC(identificador, IdRecep);
        }
        public DataTable getDatosInvoice(string identificador)
        {
            return this.modelFact.getDatosInvoice(identificador);
        }

        public DataTable getDatosMaster(string identificador)
        {
            return this.modelFact.getDatosMaster(identificador);
        }

        public void insertaFactura(string fact, string fecha)
        {
            this.modelFact.insertaFactura(fact, fecha);
        }
        public DataTable getDatosSegmentos(string orden)
        {
            return this.modelFact.getDatosSegmentos(orden);
        }
    }
}