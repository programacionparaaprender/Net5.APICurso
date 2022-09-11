using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidationApp.Web.Migrations
{
    public partial class v10005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcuerdoEquipos",
                columns: table => new
                {
                    AcuerdoEquipoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CFM_ID_ACUERDO = table.Column<string>(nullable: true),
                    CFM_F_CREA_ACUERDO = table.Column<string>(nullable: true),
                    CFM_CICLO_FACTURA = table.Column<string>(nullable: true),
                    CFM_CUENTA_FINANCIERA = table.Column<string>(nullable: true),
                    CFM_BA = table.Column<string>(nullable: true),
                    CFM_TIPO_COMPROBANTE = table.Column<string>(nullable: true),
                    CFM_MONTO_FINANCIADO = table.Column<string>(nullable: true),
                    CFM_MTO_DEUDA_PENDIENTE = table.Column<string>(nullable: true),
                    CFM_NUM_CUOTAS_NEGOCIADAS = table.Column<string>(nullable: true),
                    CFM_SERIE_EQUIPO_IMEI = table.Column<string>(nullable: true),
                    CFM_TELEFONO = table.Column<string>(nullable: true),
                    CFM_ID_SUSCRIPTOR = table.Column<string>(nullable: true),
                    CFM_TIPO_DOCUMENTO = table.Column<string>(nullable: true),
                    CFM_NUM_DOCUMENTO = table.Column<string>(nullable: true),
                    CFM_SAP_ID = table.Column<string>(nullable: true),
                    CFM_ESTADO_ACUERDO_FINANC = table.Column<string>(nullable: true),
                    CFM_LOTE_CARGA = table.Column<string>(nullable: true),
                    FECHA = table.Column<DateTime>(nullable: true),
                    ACUERDO_MULTIPLE = table.Column<bool>(nullable: true),
                    CICLOID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcuerdoEquipos", x => x.AcuerdoEquipoId);
                });

            migrationBuilder.CreateTable(
                name: "AcuerdoEquiposCuotas",
                columns: table => new
                {
                    AcuerdoEquiposCuotasId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcuerdoEquipoId = table.Column<long>(nullable: true),
                    CFM_ID_ACUERDO_CUOTA = table.Column<string>(nullable: true),
                    CFM_ID_CUOTA = table.Column<string>(nullable: true),
                    CFM_NUM_RECIBO_CICLO = table.Column<string>(nullable: true),
                    CFM_F_VENC_RECIBO_CICLO = table.Column<string>(nullable: true),
                    CFM_F_ENVIO_CUOTA_MENSUAL = table.Column<string>(nullable: true),
                    CFM_NUM_CUOTA = table.Column<string>(nullable: true),
                    CFM_MONTO_CUOTA_MENSUAL = table.Column<string>(nullable: true),
                    CFM_ESTADO_CUOTA = table.Column<string>(nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(nullable: true),
                    FECHA_UPDATE = table.Column<DateTime>(nullable: true),
                    RECIBOID = table.Column<long>(nullable: true),
                    DETALLERECIBOID = table.Column<long>(nullable: true),
                    CICLICARECIBO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcuerdoEquiposCuotas", x => x.AcuerdoEquiposCuotasId);
                });

            migrationBuilder.CreateTable(
                name: "Base_App_movil_Incremento2022_C17",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_digo_de_Componente_Antiguo = table.Column<string>(nullable: true),
                    C_digo_de_Componente_Nuevo = table.Column<string>(nullable: true),
                    Monto_Componente_Antiguo = table.Column<double>(nullable: false),
                    Monto_Componente_Nuevo = table.Column<double>(nullable: false),
                    Datos_Internet = table.Column<double>(nullable: false),
                    Datos_Internet_Nuevo = table.Column<string>(nullable: true),
                    Componente = table.Column<string>(nullable: true),
                    Nombre_Plan_Antiguo = table.Column<string>(nullable: true),
                    Nombre_Plan_Nuevo = table.Column<string>(nullable: true),
                    Numero_de_gestion_Fija_o_Movil = table.Column<string>(nullable: true),
                    AplicaTratamientoComercial = table.Column<string>(nullable: true),
                    AplicaDescuento = table.Column<string>(nullable: true),
                    AplicaCambioPlan = table.Column<string>(nullable: true),
                    Fecha_de_incremento = table.Column<DateTime>(nullable: false),
                    Monto_de_incremento = table.Column<double>(nullable: false),
                    Plan_anterior = table.Column<string>(nullable: true),
                    Plan_con_incremento = table.Column<string>(nullable: true),
                    Renta_paquete_anterior = table.Column<string>(nullable: true),
                    Renta_paquete_nuevo = table.Column<string>(nullable: true),
                    Monto_de_descuento_06_meses = table.Column<double>(nullable: false),
                    TIPO_INCREMENTO = table.Column<string>(nullable: true),
                    Telefono_fijo = table.Column<string>(nullable: true),
                    MES_INCREMENTADO = table.Column<string>(nullable: true),
                    MES_VENCIMIENTO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_App_movil_Incremento2022_C17", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampanaFijaFrac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANEXO = table.Column<int>(nullable: false),
                    CLIENTE = table.Column<int>(nullable: false),
                    TELEFONO = table.Column<string>(nullable: true),
                    CLUSTER = table.Column<string>(nullable: true),
                    SUB_CLUSTER = table.Column<string>(nullable: true),
                    LOB_TYPE = table.Column<string>(nullable: true),
                    TELF_LEG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanaFijaFrac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampanaFijaMig",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANEXO = table.Column<int>(nullable: false),
                    CLIENTE = table.Column<int>(nullable: false),
                    TELEFONO = table.Column<string>(nullable: true),
                    CLUSTER = table.Column<string>(nullable: true),
                    SUB_CLUSTER = table.Column<string>(nullable: true),
                    LOB_TYPE = table.Column<string>(nullable: true),
                    TELF_LEG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanaFijaMig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampanaFracMovil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FINANCIAL_ACCOUNT_KEY = table.Column<int>(nullable: false),
                    ANEXO = table.Column<int>(nullable: false),
                    TELEFONO = table.Column<string>(nullable: true),
                    CLUSTER = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanaFracMovil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaniaFinanciamientos",
                columns: table => new
                {
                    CampaniaFinanciamientoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaniaFinanciamientos", x => x.CampaniaFinanciamientoId);
                });

            migrationBuilder.CreateTable(
                name: "CampaniaGenerales",
                columns: table => new
                {
                    CampaniaGeneralId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(nullable: true),
                    CodigoCampania = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaniaGenerales", x => x.CampaniaGeneralId);
                });

            migrationBuilder.CreateTable(
                name: "CargaEstados",
                columns: table => new
                {
                    CargaEstadoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaEstados", x => x.CargaEstadoId);
                });

            migrationBuilder.CreateTable(
                name: "CargaExtraccion",
                columns: table => new
                {
                    CargaExtraccionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargaId = table.Column<long>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaExtraccion", x => x.CargaExtraccionId);
                });

            migrationBuilder.CreateTable(
                name: "CargaExtraccionTablas",
                columns: table => new
                {
                    CargaExtraccionTablaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargaExtraccionId = table.Column<long>(nullable: false),
                    NombreLegado = table.Column<string>(nullable: true),
                    NombreBrainy = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaExtraccionTablas", x => x.CargaExtraccionTablaId);
                });

            migrationBuilder.CreateTable(
                name: "CargaOrigenes",
                columns: table => new
                {
                    CargaOrigenId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Legado = table.Column<string>(nullable: true),
                    Ip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaOrigenes", x => x.CargaOrigenId);
                });

            migrationBuilder.CreateTable(
                name: "Cargas",
                columns: table => new
                {
                    CargaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciclo = table.Column<DateTime>(nullable: false),
                    FechaProgramada = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Inicio = table.Column<DateTime>(nullable: true),
                    Fin = table.Column<DateTime>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    creado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargas", x => x.CargaId);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaCargo",
                columns: table => new
                {
                    CategoriaCargoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Icono = table.Column<string>(nullable: true),
                    Orden = table.Column<int>(nullable: true),
                    DescripcionPlural = table.Column<string>(nullable: true),
                    AgrupacionCargo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaCargo", x => x.CategoriaCargoId);
                });

            migrationBuilder.CreateTable(
                name: "Ciclo",
                columns: table => new
                {
                    CicloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    UltimoDiaPago = table.Column<int>(nullable: false),
                    DiaReinicio = table.Column<int>(nullable: false),
                    PagoMesAnterior = table.Column<bool>(nullable: true),
                    DiaEmision = table.Column<int>(nullable: true),
                    PagoMesAnteriorFE = table.Column<bool>(nullable: true),
                    CodigoAtis = table.Column<string>(nullable: true),
                    OrigenAtis = table.Column<bool>(nullable: true),
                    OrigenALDM = table.Column<bool>(nullable: true),
                    AdmiteMT = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclo", x => x.CicloId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDocumento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EsActivo = table.Column<bool>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FechaActualizacion = table.Column<DateTime>(nullable: false),
                    Provincia = table.Column<string>(nullable: true),
                    LOTE = table.Column<string>(nullable: true),
                    TipoDoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Email = table.Column<string>(maxLength: 32, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incremento",
                columns: table => new
                {
                    IncrementoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciclica = table.Column<DateTime>(nullable: false),
                    EsActivo = table.Column<bool>(nullable: false),
                    EsAutogestionable = table.Column<bool>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: true),
                    TipoIncremento = table.Column<string>(nullable: true),
                    EsRentaVencida = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incremento", x => x.IncrementoId);
                });

            migrationBuilder.CreateTable(
                name: "Reclamo",
                columns: table => new
                {
                    ReclamoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: true),
                    CodigoSAR = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    CasoCRM = table.Column<string>(nullable: true),
                    CerrarCasoTransaccionId = table.Column<string>(nullable: true),
                    EsIncremento = table.Column<bool>(nullable: true),
                    SmsEnviado = table.Column<bool>(nullable: false),
                    NumeroReciboBU = table.Column<string>(nullable: true),
                    CiclicaReciboBU = table.Column<string>(nullable: true),
                    ReciboIdBU = table.Column<long>(nullable: true),
                    EsAveria = table.Column<bool>(nullable: true),
                    CampaniaGeneralId = table.Column<int>(nullable: true),
                    NumeroDocumento = table.Column<string>(nullable: true),
                    TipoAveria = table.Column<string>(nullable: true),
                    DeudaRegistrada = table.Column<decimal>(nullable: true),
                    ServicioAveria = table.Column<int>(nullable: true),
                    DiasAveria = table.Column<string>(nullable: true),
                    TipoIncremento = table.Column<string>(nullable: true),
                    EsRentaVencida = table.Column<bool>(nullable: true),
                    EsMasSimple = table.Column<bool>(nullable: true),
                    TipoRecibo = table.Column<string>(nullable: true),
                    TieneDeuda = table.Column<bool>(nullable: true),
                    TieneReclamoPiloto = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamo", x => x.ReclamoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoCliente",
                columns: table => new
                {
                    TipoClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCliente", x => x.TipoClienteId);
                });

            migrationBuilder.CreateTable(
                name: "TipoReciboVariacion",
                columns: table => new
                {
                    TipoReciboVariacionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoReciboVariacion", x => x.TipoReciboVariacionId);
                });

            migrationBuilder.CreateTable(
                name: "TipoVariacion",
                columns: table => new
                {
                    TipoVariacionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVariacion", x => x.TipoVariacionId);
                });

            migrationBuilder.CreateTable(
                name: "AgrupacionCargo",
                columns: table => new
                {
                    AgrupacionCargoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaCargoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgrupacionCargo", x => x.AgrupacionCargoId);
                    table.ForeignKey(
                        name: "FK_AgrupacionCargo_CategoriaCargo_CategoriaCargoId",
                        column: x => x.CategoriaCargoId,
                        principalTable: "CategoriaCargo",
                        principalColumn: "CategoriaCargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotivoReclamo",
                columns: table => new
                {
                    MotivoReclamoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCargo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    CategoriaCargoId = table.Column<int>(nullable: true),
                    Orden = table.Column<int>(nullable: true),
                    EsActivo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoReclamo", x => x.MotivoReclamoId);
                    table.ForeignKey(
                        name: "FK_MotivoReclamo_CategoriaCargo_CategoriaCargoId",
                        column: x => x.CategoriaCargoId,
                        principalTable: "CategoriaCargo",
                        principalColumn: "CategoriaCargoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoAjusteRecibo",
                columns: table => new
                {
                    TipoAjusteReciboId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    CategoriaCargoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAjusteRecibo", x => x.TipoAjusteReciboId);
                    table.ForeignKey(
                        name: "FK_TipoAjusteRecibo_CategoriaCargo_CategoriaCargoId",
                        column: x => x.CategoriaCargoId,
                        principalTable: "CategoriaCargo",
                        principalColumn: "CategoriaCargoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionFinanciamiento",
                columns: table => new
                {
                    ConfiguracionFinanciamientoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicloId = table.Column<int>(nullable: false),
                    Ciclica = table.Column<string>(nullable: true),
                    EsActivo = table.Column<bool>(nullable: false),
                    CampaniaFinanciamientoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionFinanciamiento", x => x.ConfiguracionFinanciamientoId);
                    table.ForeignKey(
                        name: "FK_ConfiguracionFinanciamiento_CampaniaFinanciamientos_CampaniaFinanciamientoId",
                        column: x => x.CampaniaFinanciamientoId,
                        principalTable: "CampaniaFinanciamientos",
                        principalColumn: "CampaniaFinanciamientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfiguracionFinanciamiento_Ciclo_CicloId",
                        column: x => x.CicloId,
                        principalTable: "Ciclo",
                        principalColumn: "CicloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    ContactoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<long>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    LOTE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.ContactoId);
                    table.ForeignKey(
                        name: "FK_Contacto_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginMT",
                columns: table => new
                {
                    LoginMTId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<long>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Ciclica = table.Column<string>(nullable: true),
                    FechaIntentoSesion = table.Column<DateTimeOffset>(nullable: true),
                    ContadorIntentoFallido = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginMT", x => x.LoginMTId);
                    table.ForeignKey(
                        name: "FK_LoginMT_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(maxLength: 5, nullable: false),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncrementoCliente",
                columns: table => new
                {
                    IncrementoClienteId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncrementoId = table.Column<long>(nullable: true),
                    ClienteId = table.Column<long>(nullable: true),
                    Telefono = table.Column<long>(nullable: true),
                    Origen = table.Column<string>(nullable: true),
                    AplicaAutogestion = table.Column<bool>(nullable: true),
                    AplicaDescuento = table.Column<bool>(nullable: true),
                    AplicaCambioPlan = table.Column<bool>(nullable: true),
                    VistasPopup = table.Column<int>(nullable: true),
                    FechaIncremento = table.Column<DateTime>(nullable: true),
                    MesIncremento = table.Column<string>(nullable: true),
                    MesIncrementoVence = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncrementoCliente", x => x.IncrementoClienteId);
                    table.ForeignKey(
                        name: "FK_IncrementoCliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncrementoCliente_Incremento_IncrementoId",
                        column: x => x.IncrementoId,
                        principalTable: "Incremento",
                        principalColumn: "IncrementoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    CargoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Traduccion = table.Column<string>(nullable: true),
                    MontoReferencial = table.Column<decimal>(nullable: true),
                    Clasificacion = table.Column<string>(nullable: true),
                    EsReclamable = table.Column<bool>(nullable: false),
                    TipoCargo = table.Column<string>(nullable: true),
                    OrigenDato = table.Column<string>(nullable: true),
                    EsActivo = table.Column<bool>(nullable: false),
                    CategoriaCargoId = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    ChargeCodeKeyMovil = table.Column<string>(nullable: true),
                    MontoPlan = table.Column<decimal>(nullable: true),
                    EsRentaVencida = table.Column<bool>(nullable: true),
                    AgrupacionCargoId = table.Column<long>(nullable: true),
                    Ciclica = table.Column<DateTime>(nullable: true),
                    EsRentaCargo = table.Column<bool>(nullable: true),
                    EsVelocidadInternet = table.Column<bool>(nullable: true),
                    EsGestionableBaja = table.Column<bool>(nullable: true),
                    EsReclamableBU = table.Column<bool>(nullable: true),
                    CofaVO = table.Column<string>(nullable: true),
                    ProductCatalogKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_Cargo_AgrupacionCargo_AgrupacionCargoId",
                        column: x => x.AgrupacionCargoId,
                        principalTable: "AgrupacionCargo",
                        principalColumn: "AgrupacionCargoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cargo_CategoriaCargo_CategoriaCargoId",
                        column: x => x.CategoriaCargoId,
                        principalTable: "CategoriaCargo",
                        principalColumn: "CategoriaCargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleReclamo",
                columns: table => new
                {
                    SolicitudReclamoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleReciboId = table.Column<long>(nullable: true),
                    MotivoReclamoId = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    CasoCRM = table.Column<int>(nullable: false),
                    CodigoSAR = table.Column<string>(nullable: true),
                    Ajustado = table.Column<bool>(nullable: true),
                    TipoUsuario = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Usuario = table.Column<string>(nullable: true),
                    ReclamoId = table.Column<long>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    NotaCredito = table.Column<string>(nullable: true),
                    EsFraccionado = table.Column<bool>(nullable: true),
                    NumeroReciboBU = table.Column<string>(nullable: true),
                    CiclicaReciboBU = table.Column<string>(nullable: true),
                    ReciboIdBU = table.Column<long>(nullable: true),
                    DetalleReciboIdBU = table.Column<long>(nullable: true),
                    MontoBU = table.Column<decimal>(nullable: true),
                    CargoIdBU = table.Column<long>(nullable: true),
                    FechaMovimientoBU = table.Column<DateTime>(nullable: true),
                    FechaInicioBU = table.Column<DateTime>(nullable: true),
                    FechaFinBU = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleReclamo", x => x.SolicitudReclamoId);
                    table.ForeignKey(
                        name: "FK_DetalleReclamo_MotivoReclamo_MotivoReclamoId",
                        column: x => x.MotivoReclamoId,
                        principalTable: "MotivoReclamo",
                        principalColumn: "MotivoReclamoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleReclamo_Reclamo_ReclamoId",
                        column: x => x.ReclamoId,
                        principalTable: "Reclamo",
                        principalColumn: "ReclamoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteAsociado",
                columns: table => new
                {
                    ClienteAsociadoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactoId = table.Column<long>(nullable: false),
                    CodigoCliente = table.Column<string>(nullable: true),
                    LOTE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteAsociado", x => x.ClienteAsociadoId);
                    table.ForeignKey(
                        name: "FK_ClienteAsociado_Contacto_ContactoId",
                        column: x => x.ContactoId,
                        principalTable: "Contacto",
                        principalColumn: "ContactoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncrementoCargoFija",
                columns: table => new
                {
                    IncrementoCargoFijaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncrementoId = table.Column<long>(nullable: true),
                    IncrementoClienteId = table.Column<long>(nullable: true),
                    CargoId = table.Column<long>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    CargoIdNew = table.Column<long>(nullable: true),
                    MontoNew = table.Column<decimal>(nullable: true),
                    MontoDescuento = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncrementoCargoFija", x => x.IncrementoCargoFijaId);
                    table.ForeignKey(
                        name: "FK_IncrementoCargoFija_IncrementoCliente_IncrementoClienteId",
                        column: x => x.IncrementoClienteId,
                        principalTable: "IncrementoCliente",
                        principalColumn: "IncrementoClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncrementoCargoFija_Incremento_IncrementoId",
                        column: x => x.IncrementoId,
                        principalTable: "Incremento",
                        principalColumn: "IncrementoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncrementoCargoFijaMasSimple",
                columns: table => new
                {
                    IncrementoCargoFijaMasSimpleId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncrementoClienteId = table.Column<long>(nullable: true),
                    CodigoCargo = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    CodigoCargoNew = table.Column<string>(nullable: true),
                    MontoNew = table.Column<decimal>(nullable: true),
                    Imagen = table.Column<string>(nullable: true),
                    planCd = table.Column<long>(nullable: true),
                    DatosInternet = table.Column<decimal>(nullable: true),
                    DatosInternetNew = table.Column<decimal>(nullable: true),
                    NombrePlan = table.Column<string>(nullable: true),
                    NombrePlanNew = table.Column<string>(nullable: true),
                    MontoDescuento = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncrementoCargoFijaMasSimple", x => x.IncrementoCargoFijaMasSimpleId);
                    table.ForeignKey(
                        name: "FK_IncrementoCargoFijaMasSimple_IncrementoCliente_IncrementoClienteId",
                        column: x => x.IncrementoClienteId,
                        principalTable: "IncrementoCliente",
                        principalColumn: "IncrementoClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncrementoCargo",
                columns: table => new
                {
                    IncrementoCargoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncrementoId = table.Column<long>(nullable: true),
                    CargoId = table.Column<long>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    CargoIdNew = table.Column<long>(nullable: true),
                    MontoNew = table.Column<decimal>(nullable: true),
                    Imagen = table.Column<string>(nullable: true),
                    planCd = table.Column<long>(nullable: true),
                    DatosInternet = table.Column<decimal>(nullable: true),
                    DatosInternetNew = table.Column<decimal>(nullable: true),
                    NombrePlan = table.Column<string>(nullable: true),
                    NombrePlanNew = table.Column<string>(nullable: true),
                    MontoDescuento = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncrementoCargo", x => x.IncrementoCargoId);
                    table.ForeignKey(
                        name: "FK_IncrementoCargo_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncrementoCargo_Incremento_IncrementoId",
                        column: x => x.IncrementoId,
                        principalTable: "Incremento",
                        principalColumn: "IncrementoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuentaCliente",
                columns: table => new
                {
                    CuentaClienteId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteAsociadoId = table.Column<long>(nullable: false),
                    CodigoCuenta = table.Column<string>(nullable: true),
                    CuentaFinanciera = table.Column<string>(nullable: true),
                    TipoClienteId = table.Column<int>(nullable: true),
                    LOTE = table.Column<string>(nullable: true),
                    TipoNumero = table.Column<int>(nullable: true),
                    EsMasSimple = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaCliente", x => x.CuentaClienteId);
                    table.ForeignKey(
                        name: "FK_CuentaCliente_ClienteAsociado_ClienteAsociadoId",
                        column: x => x.ClienteAsociadoId,
                        principalTable: "ClienteAsociado",
                        principalColumn: "ClienteAsociadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuentaCliente_TipoCliente_TipoClienteId",
                        column: x => x.TipoClienteId,
                        principalTable: "TipoCliente",
                        principalColumn: "TipoClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recibo",
                columns: table => new
                {
                    ReciboId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroRecibo = table.Column<string>(nullable: true),
                    FechaEmision = table.Column<DateTime>(nullable: true),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    Ciclica = table.Column<DateTime>(nullable: true),
                    CicloId = table.Column<int>(nullable: true),
                    EstadoLinea = table.Column<string>(nullable: true),
                    UrlRecibo = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: true),
                    CuentaClienteId = table.Column<long>(nullable: true),
                    MontoTotal = table.Column<decimal>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    MontoIGV = table.Column<decimal>(nullable: true),
                    EstaPagado = table.Column<bool>(nullable: true),
                    TipoPaq = table.Column<string>(nullable: true),
                    Variacion = table.Column<string>(nullable: true),
                    PaqActual = table.Column<string>(nullable: true),
                    PaqAnterior = table.Column<string>(nullable: true),
                    LOTE = table.Column<string>(nullable: true),
                    VisualizacionIncremento = table.Column<short>(nullable: true),
                    EsAgrupado = table.Column<bool>(nullable: true),
                    TipoMonedaId = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    InvoiceKey = table.Column<string>(nullable: true),
                    EsMasSimple = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibo", x => x.ReciboId);
                    table.ForeignKey(
                        name: "FK_Recibo_Ciclo_CicloId",
                        column: x => x.CicloId,
                        principalTable: "Ciclo",
                        principalColumn: "CicloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recibo_CuentaCliente_CuentaClienteId",
                        column: x => x.CuentaClienteId,
                        principalTable: "CuentaCliente",
                        principalColumn: "CuentaClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AjusteRecibos",
                columns: table => new
                {
                    AjusteReciboId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: false),
                    MontoAjustado = table.Column<decimal>(nullable: false),
                    MontoAjustadoIGV = table.Column<decimal>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoAjusteReciboId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjusteRecibos", x => x.AjusteReciboId);
                    table.ForeignKey(
                        name: "FK_AjusteRecibos_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AjusteRecibos_TipoAjusteRecibo_TipoAjusteReciboId",
                        column: x => x.TipoAjusteReciboId,
                        principalTable: "TipoAjusteRecibo",
                        principalColumn: "TipoAjusteReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bajas",
                columns: table => new
                {
                    BajaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    CodigoCliente = table.Column<string>(nullable: true),
                    CodigoCuenta = table.Column<string>(nullable: true),
                    CuentaFinanciera = table.Column<string>(nullable: true),
                    NumeroDocumento = table.Column<string>(nullable: true),
                    CodigoBaja = table.Column<string>(nullable: true),
                    TipoNumero = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bajas", x => x.BajaId);
                    table.ForeignKey(
                        name: "FK_Bajas_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DescuentoIncremento",
                columns: table => new
                {
                    DescuentoIncrementoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: true),
                    CampaniaGeneralId = table.Column<int>(nullable: true),
                    NumeroRecibo = table.Column<string>(nullable: true),
                    CodigoDescuento = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: true),
                    MontoDescuentoMes = table.Column<decimal>(nullable: true),
                    TipoIncremento = table.Column<string>(nullable: true),
                    TipoNumero = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    MotivoDescuento = table.Column<string>(nullable: true),
                    EsRentaVencida = table.Column<bool>(nullable: true),
                    TieneDeuda = table.Column<bool>(nullable: true),
                    DatosInternet = table.Column<decimal>(nullable: true),
                    DatosInternetNew = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescuentoIncremento", x => x.DescuentoIncrementoId);
                    table.ForeignKey(
                        name: "FK_DescuentoIncremento_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleRecibo",
                columns: table => new
                {
                    DetalleReciboId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: false),
                    CargoId = table.Column<long>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    FechaMovimiento = table.Column<DateTime>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: true),
                    FechaFin = table.Column<DateTime>(nullable: true),
                    DuracionPromo = table.Column<int>(nullable: true),
                    IntervaloPromo = table.Column<string>(nullable: true),
                    PorcentajePromo = table.Column<decimal>(nullable: true),
                    MontoFacturado = table.Column<decimal>(nullable: true),
                    MontoFacturadoIGV = table.Column<decimal>(nullable: true),
                    MontoRestringido = table.Column<decimal>(nullable: true),
                    MontoRestringidoIGV = table.Column<decimal>(nullable: true),
                    MontoDisputado = table.Column<decimal>(nullable: true),
                    MontoDisputadoIGV = table.Column<decimal>(nullable: true),
                    CuotaActual = table.Column<int>(nullable: true),
                    CuotaTotal = table.Column<int>(nullable: true),
                    ChargeCodeKeyMovil = table.Column<string>(nullable: true),
                    ChargeRequestIdMovil = table.Column<string>(nullable: true),
                    ChargeServRecvIdMovil = table.Column<string>(nullable: true),
                    ChargeIdAR = table.Column<string>(nullable: true),
                    EsPartePlan = table.Column<bool>(nullable: true),
                    GrupoDetalle = table.Column<string>(nullable: true),
                    ProductoServicioId = table.Column<long>(nullable: true),
                    Equipo = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    EsDescuentoPlan = table.Column<bool>(nullable: true),
                    TipoRenta = table.Column<string>(nullable: true),
                    TipoAfectacion = table.Column<string>(nullable: true),
                    PaqueteId = table.Column<string>(nullable: true),
                    EsFacturadoCompleto = table.Column<bool>(nullable: true),
                    VelocidadInternet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleRecibo", x => x.DetalleReciboId);
                    table.ForeignKey(
                        name: "FK_DetalleRecibo_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleRecibo_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoAciclico",
                columns: table => new
                {
                    DocumentoAciclicoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboAsociadoId = table.Column<long>(nullable: false),
                    CargoReferenciadoId = table.Column<long>(nullable: true),
                    TipoDocumento = table.Column<string>(nullable: true),
                    CodigoCuenta = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    MontoIGV = table.Column<decimal>(nullable: true),
                    MontoFacturado = table.Column<decimal>(nullable: true),
                    MontoFacturadoIGV = table.Column<decimal>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: true),
                    FechaFin = table.Column<DateTime>(nullable: true),
                    Ciclica = table.Column<DateTime>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: true),
                    ChargeCodeKeyMovil = table.Column<string>(nullable: true),
                    LOTE = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    ProductoServicioId = table.Column<long>(nullable: true),
                    EsCargoDevolucion = table.Column<bool>(nullable: true),
                    FechaFinCargoDevolucion = table.Column<DateTime>(nullable: true),
                    NumeroRecibo = table.Column<string>(nullable: true),
                    CargoId = table.Column<long>(nullable: true),
                    ReciboId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoAciclico", x => x.DocumentoAciclicoId);
                    table.ForeignKey(
                        name: "FK_DocumentoAciclico_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentoAciclico_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Financiamiento",
                columns: table => new
                {
                    FinanciamientoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    EstadoFTP = table.Column<string>(nullable: true),
                    RespuestaFTP = table.Column<string>(nullable: true),
                    CantidadCuota = table.Column<int>(nullable: false),
                    MontoCuota = table.Column<decimal>(nullable: false),
                    MontoFinanciado = table.Column<decimal>(nullable: false),
                    FinanciamientoArchivoFTPId = table.Column<long>(nullable: true),
                    NumeroDocumento = table.Column<string>(nullable: true),
                    CampaniaFinanciamientoId = table.Column<long>(nullable: false),
                    TipoNumero = table.Column<string>(nullable: true),
                    CodigoFinanciamiento = table.Column<string>(nullable: true),
                    CodigoPlanFinanciamiento = table.Column<string>(nullable: true),
                    Ciclica = table.Column<DateTime>(nullable: false),
                    CicloId = table.Column<int>(nullable: false),
                    TipoDocumento = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    SuscriberId = table.Column<int>(nullable: true),
                    CodigoCliente = table.Column<long>(nullable: true),
                    CuentaFinanciera = table.Column<long>(nullable: true),
                    BA = table.Column<long>(nullable: true),
                    DeudaTotal = table.Column<decimal>(nullable: true),
                    DeudaVencida = table.Column<decimal>(nullable: true),
                    Moneda = table.Column<long>(nullable: true),
                    ErrorGeneracionArchivo = table.Column<string>(nullable: true),
                    NumeroReciboBU = table.Column<string>(nullable: true),
                    ReciboIdBU = table.Column<long>(nullable: true),
                    CiclicaReciboBU = table.Column<DateTime>(nullable: true),
                    TipoNumeroBU = table.Column<string>(nullable: true),
                    CodigoFinanciamientoBU = table.Column<string>(nullable: true),
                    CodigoPlanFinanciamientoBU = table.Column<string>(nullable: true),
                    SuscriberIdBU = table.Column<int>(nullable: true),
                    CodigoClienteBU = table.Column<long>(nullable: true),
                    BABU = table.Column<long>(nullable: true),
                    MonedaBU = table.Column<long>(nullable: true),
                    NumeroRecibo = table.Column<string>(nullable: true),
                    AppOrigin = table.Column<string>(nullable: true),
                    ReciboIdAux = table.Column<long>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Canal = table.Column<string>(nullable: true),
                    EsDuplicado = table.Column<bool>(nullable: true),
                    PorcentajeDescuentoFinanciamiento = table.Column<int>(nullable: true),
                    MontoCuotaDescuento = table.Column<decimal>(nullable: true),
                    MontoFinanciadoDescuento = table.Column<decimal>(nullable: true),
                    EsPrimerFinanciamiento = table.Column<bool>(nullable: true),
                    MontoFinanciamientoExcliudo = table.Column<decimal>(nullable: true),
                    ReciboIdAux2 = table.Column<long>(nullable: true),
                    MontoCuotasPendiente = table.Column<decimal>(nullable: true),
                    CodigoAgrupador = table.Column<string>(nullable: true),
                    EsMasSimple = table.Column<bool>(nullable: true),
                    TipoRecibo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financiamiento", x => x.FinanciamientoId);
                    table.ForeignKey(
                        name: "FK_Financiamiento_CampaniaFinanciamientos_CampaniaFinanciamientoId",
                        column: x => x.CampaniaFinanciamientoId,
                        principalTable: "CampaniaFinanciamientos",
                        principalColumn: "CampaniaFinanciamientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Financiamiento_Ciclo_CicloId",
                        column: x => x.CicloId,
                        principalTable: "Ciclo",
                        principalColumn: "CicloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Financiamiento_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LogDescargaRecibo",
                columns: table => new
                {
                    LogDescargaReciboId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origen = table.Column<string>(nullable: true),
                    ReciboId = table.Column<long>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: true),
                    EsVisualizar = table.Column<bool>(nullable: true),
                    EsDescargar = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogDescargaRecibo", x => x.LogDescargaReciboId);
                    table.ForeignKey(
                        name: "FK_LogDescargaRecibo_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TokenSesion",
                columns: table => new
                {
                    TokenSesionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(nullable: true),
                    ReciboId = table.Column<long>(nullable: false),
                    FechaIntentoSesion = table.Column<DateTimeOffset>(nullable: true),
                    ContadorIntentoFallido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenSesion", x => x.TokenSesionId);
                    table.ForeignKey(
                        name: "FK_TokenSesion_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariacionRecibo",
                columns: table => new
                {
                    VariacionReciboId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReciboId = table.Column<long>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: true),
                    TipoReciboVariacionId = table.Column<int>(nullable: true),
                    TipoVariacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariacionRecibo", x => x.VariacionReciboId);
                    table.ForeignKey(
                        name: "FK_VariacionRecibo_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VariacionRecibo_TipoReciboVariacion_TipoReciboVariacionId",
                        column: x => x.TipoReciboVariacionId,
                        principalTable: "TipoReciboVariacion",
                        principalColumn: "TipoReciboVariacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VariacionRecibo_TipoVariacion_TipoVariacionId",
                        column: x => x.TipoVariacionId,
                        principalTable: "TipoVariacion",
                        principalColumn: "TipoVariacionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleBaja",
                columns: table => new
                {
                    DetalleBajaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BajaId = table.Column<long>(nullable: true),
                    DetalleReciboId = table.Column<long>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: true),
                    CodigoCargo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleBaja", x => x.DetalleBajaId);
                    table.ForeignKey(
                        name: "FK_DetalleBaja_Bajas_BajaId",
                        column: x => x.BajaId,
                        principalTable: "Bajas",
                        principalColumn: "BajaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleBaja_DetalleRecibo_DetalleReciboId",
                        column: x => x.DetalleReciboId,
                        principalTable: "DetalleRecibo",
                        principalColumn: "DetalleReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFinanciamiento",
                columns: table => new
                {
                    DetalleFinanciamientoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinanciamientoId = table.Column<long>(nullable: false),
                    ReciboId = table.Column<long>(nullable: true),
                    NumeroRecibo = table.Column<string>(nullable: true),
                    Ciclica = table.Column<DateTime>(nullable: true),
                    Monto = table.Column<decimal>(nullable: false),
                    TipoMonto = table.Column<string>(nullable: true),
                    TipoDocumentoDeuda = table.Column<string>(nullable: true),
                    ArInvoiceId = table.Column<long>(nullable: true),
                    BillingInvoiceNumber = table.Column<string>(nullable: true),
                    FechaCreacionDeuda = table.Column<DateTime>(nullable: true),
                    FechaVencimientoDeuda = table.Column<DateTime>(nullable: true),
                    TipoDocumentoDeudaBU = table.Column<string>(nullable: true),
                    ReciboIdBU = table.Column<long>(nullable: true),
                    NumeroReciboBU = table.Column<string>(nullable: true),
                    CiclicaBU = table.Column<DateTime>(nullable: true),
                    MontoExcluido = table.Column<decimal>(nullable: true),
                    MontoSinCuotasFinanciamiento = table.Column<decimal>(nullable: true),
                    CuentaFinanciera = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFinanciamiento", x => x.DetalleFinanciamientoId);
                    table.ForeignKey(
                        name: "FK_DetalleFinanciamiento_Financiamiento_FinanciamientoId",
                        column: x => x.FinanciamientoId,
                        principalTable: "Financiamiento",
                        principalColumn: "FinanciamientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleFinanciamiento_Recibo_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibo",
                        principalColumn: "ReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleLogDescargaRecibo",
                columns: table => new
                {
                    DetalleLogDescargaReciboId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDescargaReciboId = table.Column<long>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleLogDescargaRecibo", x => x.DetalleLogDescargaReciboId);
                    table.ForeignKey(
                        name: "FK_DetalleLogDescargaRecibo_LogDescargaRecibo_LogDescargaReciboId",
                        column: x => x.LogDescargaReciboId,
                        principalTable: "LogDescargaRecibo",
                        principalColumn: "LogDescargaReciboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cargas",
                columns: new[] { "CargaId", "Ciclo", "Estado", "FechaProgramada", "Fin", "Hora", "Inicio", "Tipo", "Usuario", "creado" },
                values: new object[] { 1L, new DateTime(2022, 8, 22, 9, 10, 7, 166, DateTimeKind.Local).AddTicks(1217), "", new DateTime(2022, 8, 22, 9, 10, 7, 173, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 8, 22, 9, 10, 7, 173, DateTimeKind.Local).AddTicks(9570), "", new DateTime(2022, 8, 22, 9, 10, 7, 173, DateTimeKind.Local).AddTicks(8667), "", "", new DateTime(2022, 8, 22, 9, 10, 7, 174, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_CustomerId",
                table: "Adresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AgrupacionCargo_CategoriaCargoId",
                table: "AgrupacionCargo",
                column: "CategoriaCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_AjusteRecibos_ReciboId",
                table: "AjusteRecibos",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_AjusteRecibos_TipoAjusteReciboId",
                table: "AjusteRecibos",
                column: "TipoAjusteReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_Bajas_ReciboId",
                table: "Bajas",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_AgrupacionCargoId",
                table: "Cargo",
                column: "AgrupacionCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_CategoriaCargoId",
                table: "Cargo",
                column: "CategoriaCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteAsociado_ContactoId",
                table: "ClienteAsociado",
                column: "ContactoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionFinanciamiento_CampaniaFinanciamientoId",
                table: "ConfiguracionFinanciamiento",
                column: "CampaniaFinanciamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionFinanciamiento_CicloId",
                table: "ConfiguracionFinanciamiento",
                column: "CicloId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_ClienteId",
                table: "Contacto",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaCliente_ClienteAsociadoId",
                table: "CuentaCliente",
                column: "ClienteAsociadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaCliente_TipoClienteId",
                table: "CuentaCliente",
                column: "TipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DescuentoIncremento_ReciboId",
                table: "DescuentoIncremento",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleBaja_BajaId",
                table: "DetalleBaja",
                column: "BajaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleBaja_DetalleReciboId",
                table: "DetalleBaja",
                column: "DetalleReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFinanciamiento_FinanciamientoId",
                table: "DetalleFinanciamiento",
                column: "FinanciamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFinanciamiento_ReciboId",
                table: "DetalleFinanciamiento",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleLogDescargaRecibo_LogDescargaReciboId",
                table: "DetalleLogDescargaRecibo",
                column: "LogDescargaReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRecibo_CargoId",
                table: "DetalleRecibo",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRecibo_ReciboId",
                table: "DetalleRecibo",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReclamo_MotivoReclamoId",
                table: "DetalleReclamo",
                column: "MotivoReclamoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReclamo_ReclamoId",
                table: "DetalleReclamo",
                column: "ReclamoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoAciclico_CargoId",
                table: "DocumentoAciclico",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoAciclico_ReciboId",
                table: "DocumentoAciclico",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamiento_CampaniaFinanciamientoId",
                table: "Financiamiento",
                column: "CampaniaFinanciamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamiento_CicloId",
                table: "Financiamiento",
                column: "CicloId");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamiento_ReciboId",
                table: "Financiamiento",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCargo_CargoId",
                table: "IncrementoCargo",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCargo_IncrementoId",
                table: "IncrementoCargo",
                column: "IncrementoId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCargoFija_IncrementoClienteId",
                table: "IncrementoCargoFija",
                column: "IncrementoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCargoFija_IncrementoId",
                table: "IncrementoCargoFija",
                column: "IncrementoId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCargoFijaMasSimple_IncrementoClienteId",
                table: "IncrementoCargoFijaMasSimple",
                column: "IncrementoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCliente_ClienteId",
                table: "IncrementoCliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IncrementoCliente_IncrementoId",
                table: "IncrementoCliente",
                column: "IncrementoId");

            migrationBuilder.CreateIndex(
                name: "IX_LogDescargaRecibo_ReciboId",
                table: "LogDescargaRecibo",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginMT_ClienteId",
                table: "LoginMT",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MotivoReclamo_CategoriaCargoId",
                table: "MotivoReclamo",
                column: "CategoriaCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_CicloId",
                table: "Recibo",
                column: "CicloId");

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_CuentaClienteId",
                table: "Recibo",
                column: "CuentaClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoAjusteRecibo_CategoriaCargoId",
                table: "TipoAjusteRecibo",
                column: "CategoriaCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_TokenSesion_ReciboId",
                table: "TokenSesion",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_VariacionRecibo_ReciboId",
                table: "VariacionRecibo",
                column: "ReciboId");

            migrationBuilder.CreateIndex(
                name: "IX_VariacionRecibo_TipoReciboVariacionId",
                table: "VariacionRecibo",
                column: "TipoReciboVariacionId");

            migrationBuilder.CreateIndex(
                name: "IX_VariacionRecibo_TipoVariacionId",
                table: "VariacionRecibo",
                column: "TipoVariacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcuerdoEquipos");

            migrationBuilder.DropTable(
                name: "AcuerdoEquiposCuotas");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "AjusteRecibos");

            migrationBuilder.DropTable(
                name: "Base_App_movil_Incremento2022_C17");

            migrationBuilder.DropTable(
                name: "CampanaFijaFrac");

            migrationBuilder.DropTable(
                name: "CampanaFijaMig");

            migrationBuilder.DropTable(
                name: "CampanaFracMovil");

            migrationBuilder.DropTable(
                name: "CampaniaGenerales");

            migrationBuilder.DropTable(
                name: "CargaEstados");

            migrationBuilder.DropTable(
                name: "CargaExtraccion");

            migrationBuilder.DropTable(
                name: "CargaExtraccionTablas");

            migrationBuilder.DropTable(
                name: "CargaOrigenes");

            migrationBuilder.DropTable(
                name: "Cargas");

            migrationBuilder.DropTable(
                name: "ConfiguracionFinanciamiento");

            migrationBuilder.DropTable(
                name: "DescuentoIncremento");

            migrationBuilder.DropTable(
                name: "DetalleBaja");

            migrationBuilder.DropTable(
                name: "DetalleFinanciamiento");

            migrationBuilder.DropTable(
                name: "DetalleLogDescargaRecibo");

            migrationBuilder.DropTable(
                name: "DetalleReclamo");

            migrationBuilder.DropTable(
                name: "DocumentoAciclico");

            migrationBuilder.DropTable(
                name: "IncrementoCargo");

            migrationBuilder.DropTable(
                name: "IncrementoCargoFija");

            migrationBuilder.DropTable(
                name: "IncrementoCargoFijaMasSimple");

            migrationBuilder.DropTable(
                name: "LoginMT");

            migrationBuilder.DropTable(
                name: "TokenSesion");

            migrationBuilder.DropTable(
                name: "VariacionRecibo");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TipoAjusteRecibo");

            migrationBuilder.DropTable(
                name: "Bajas");

            migrationBuilder.DropTable(
                name: "DetalleRecibo");

            migrationBuilder.DropTable(
                name: "Financiamiento");

            migrationBuilder.DropTable(
                name: "LogDescargaRecibo");

            migrationBuilder.DropTable(
                name: "MotivoReclamo");

            migrationBuilder.DropTable(
                name: "Reclamo");

            migrationBuilder.DropTable(
                name: "IncrementoCliente");

            migrationBuilder.DropTable(
                name: "TipoReciboVariacion");

            migrationBuilder.DropTable(
                name: "TipoVariacion");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "CampaniaFinanciamientos");

            migrationBuilder.DropTable(
                name: "Recibo");

            migrationBuilder.DropTable(
                name: "Incremento");

            migrationBuilder.DropTable(
                name: "AgrupacionCargo");

            migrationBuilder.DropTable(
                name: "Ciclo");

            migrationBuilder.DropTable(
                name: "CuentaCliente");

            migrationBuilder.DropTable(
                name: "CategoriaCargo");

            migrationBuilder.DropTable(
                name: "ClienteAsociado");

            migrationBuilder.DropTable(
                name: "TipoCliente");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
