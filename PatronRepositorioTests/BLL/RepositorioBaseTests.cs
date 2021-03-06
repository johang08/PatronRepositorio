﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cuenta cuenta = new Cuenta();
            cuenta.CuentaId = 01;
            cuenta.Descripcion = "Johan";
            RepositorioBase<Cuenta> repositorio;
            repositorio = new RepositorioBase<Cuenta>();
            Assert.IsTrue(repositorio.Guardar(cuenta));
        }
    }
}