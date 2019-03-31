using System.Web;
using System.Web.Optimization;

namespace Bundle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Ele permite que o bundle acesse os arquivos
            BundleTable.EnableOptimizations = true;
            //Bundle que vai acessar todo diretorio da pasta comum, pegando somente arquivos .js, com o parametro true que vai percorrer as subpastas tambem
            bundles.Add(new ScriptBundle("~/comum").IncludeDirectory("~/Scripts/comum", "*.js", true));

            //Ignorando um arquivo ou subs arquivos
            bundles.IgnoreList.Ignore("*.dbg.js");


            //Colocando os arquivos JS em ordem
            var ordem = new BundleFileSetOrdering("meuScript");//Nome de referência meuScript
            ordem.Files.Add("setup.js");
            ordem.Files.Add("display.js");
            //Inserindo a ordem dos arquivos
            bundles.FileSetOrderList.Insert(0,ordem);



            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
