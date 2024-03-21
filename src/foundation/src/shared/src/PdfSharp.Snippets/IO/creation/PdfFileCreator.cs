﻿// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Quality;

namespace PdfSharp.Snippets
{
    public class PdfFileCreator : Snippet
    {
        public PdfFileCreator()
        {
            Title = "PDF files with lots of pages";
        }

        public void AddPages(PdfDocument document, int count)
        {
            for (int i = 0; i < count; i++)
            {
                AddPage(document);
            }
        }

        public void AddPage(PdfDocument document)
        {
            const int x = 40;
            const int y = 50;
            var page = document.AddPage();
            var renderer = XGraphics.FromPdfPage(page);
            var tf = new XTextFormatter(renderer);
            var width = page.Width.Value - 50 - x;
            var height = page.Height.Value - 50 - y;
            var rect = new XRect(40, 50, width, height);
            renderer.DrawRectangle(XBrushes.SeaShell, rect);
            var font = new XFont("Segoe Wp", 10);
            tf.DrawString(TestData.LoremIpsumText, font, XBrushes.Black, rect, XStringFormats.TopLeft);
        }

        public override void RenderSnippet(XGraphics gfx)
        {
            BeginBox(gfx, 1, BoxOptions.Tile);
            {
            }
            EndBox(gfx);

            BeginBox(gfx, 2, BoxOptions.Box);
            { }
            EndBox(gfx);

            BeginBox(gfx, 3, BoxOptions.Tile);
            {
            }
            EndBox(gfx);

            BeginBox(gfx, 4, BoxOptions.Box);
            { }
            EndBox(gfx);

            BeginBox(gfx, 5, BoxOptions.Tile);
            {
            }
            EndBox(gfx);

            BeginBox(gfx, 6, BoxOptions.Box);
            { }
            EndBox(gfx);

            BeginBox(gfx, 7, BoxOptions.Fill);
            { }
            EndBox(gfx);

            BeginBox(gfx, 8, BoxOptions.Fill);
            { }
            EndBox(gfx);
        }
    }

    public static class TestData
    {
        // ReSharper disable StringLiteralTypo
        public static string LoremIpsumText = """
             Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non sapien leo. Aliquam elementum volutpat lacus, sit amet aliquet est volutpat at. Nam eleifend vehicula bibendum. Sed lacinia velit ex, id auctor tellus varius a. Vivamus cursus ut nulla quis pretium. Nunc accumsan felis nec tortor fermentum iaculis. Vivamus non lacus ullamcorper, porta justo ut, dictum nibh. Cras scelerisque in risus vitae hendrerit. Duis venenatis felis in lacinia vestibulum. Proin mauris ex, efficitur nec tincidunt in, imperdiet eget risus. Nulla porttitor mollis pellentesque. Fusce pretium ut odio et imperdiet.
             Vivamus euismod velit id massa mollis, quis congue metus faucibus. Donec ante enim, vehicula a cursus ut, porta vel dui. Proin porta faucibus dolor non consequat. Mauris aliquam, leo a interdum pretium, tellus nisi semper libero, at suscipit dui mi bibendum turpis. Phasellus tempor mauris a eleifend placerat. Fusce in velit ut lectus sagittis varius. Etiam vulputate, libero sit amet posuere posuere, orci nunc ultricies velit, non porttitor dui ante feugiat purus. Ut semper congue lacinia. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed facilisis ante at sapien dignissim, ut volutpat elit dictum. Morbi nulla ante, laoreet non vulputate et, facilisis ut lectus. Mauris mollis mi nec venenatis congue. Fusce efficitur vitae massa non vehicula. Fusce euismod molestie posuere. Nunc facilisis ipsum nec justo scelerisque, nec cursus diam gravida.
             Morbi at sapien risus. Nunc dui tellus, faucibus rhoncus euismod vitae, maximus at lacus. Nam neque dui, venenatis at euismod vel, ullamcorper a velit. Maecenas placerat tellus quis justo feugiat molestie. Mauris tristique sollicitudin nisi at sagittis. Integer eleifend, velit et facilisis rutrum, nisi ipsum sodales turpis, non dictum odio dui sed velit. Aliquam consequat ac lorem non hendrerit. Morbi quis mollis nibh, et mattis nisi. Donec nec ultricies dui, nec pellentesque sapien. Vivamus sed lectus fermentum mauris placerat sodales ut sed quam. Nam facilisis, risus quis hendrerit mattis, velit nisi placerat neque, in feugiat urna nisl in nibh. Suspendisse potenti. Proin sollicitudin maximus ligula, eu sodales tellus posuere vitae. Integer orci magna, ultricies in luctus a, euismod quis lectus. Phasellus blandit justo mauris, nec maximus sapien tempor non. Ut eu quam aliquam, facilisis nibh sit amet, blandit eros.
             Nulla accumsan augue diam, sed egestas ipsum vestibulum vel. Praesent vitae dignissim quam. Nunc mollis tincidunt vehicula. In vitae euismod urna, eget tincidunt magna. In quis ligula eu magna vehicula venenatis. Vestibulum sapien sem, congue in congue et, vehicula et risus. Suspendisse aliquam, est et commodo porta, nibh tortor mollis nisi, quis porttitor ligula leo a ipsum. Aliquam viverra sodales leo quis faucibus.
             In sit amet laoreet nisl. Aenean et tortor diam. Maecenas imperdiet massa eget justo faucibus dignissim. Donec nec finibus diam, vel lobortis neque. Ut justo felis, suscipit et justo ultrices, fringilla convallis nisi. Vestibulum egestas felis vehicula tellus maximus, a ultrices magna aliquet. Cras eu laoreet mauris. Duis id euismod est. Nulla facilisi. Vivamus fermentum metus velit, vitae vulputate lectus laoreet in. Aenean semper ante odio. Ut aliquam ligula eu enim ullamcorper, ac pellentesque enim hendrerit. Vestibulum eu efficitur nisl. Aenean tempor diam nec nulla rutrum, sit amet congue urna blandit.
             Duis ullamcorper tellus ac mattis vestibulum. Integer nibh nunc, commodo sit amet pharetra sit amet, molestie a sapien. Nulla magna orci, semper at enim non, ultricies faucibus nulla. Aenean leo ex, rutrum ut fermentum ut, fringilla sit amet diam. Morbi et congue tortor, non maximus tellus. Nunc sit amet placerat ipsum, at molestie tellus. Etiam tincidunt eleifend ligula, quis dapibus elit tempus tempor. Curabitur feugiat mattis leo eu blandit. Maecenas sed vestibulum mi. In molestie eleifend euismod. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus id turpis a magna sollicitudin pellentesque.
             Donec sollicitudin efficitur sapien iaculis fringilla. Donec rutrum sagittis dolor, at auctor turpis finibus et. Aliquam et dictum risus. Praesent viverra efficitur congue. Suspendisse condimentum posuere risus, id dignissim enim viverra ut. Aliquam eleifend nisl eu dolor luctus, nec rhoncus nisi porta. Donec ut lacinia risus. Curabitur bibendum lacus consequat sem consequat euismod. Donec auctor cursus ante quis rutrum. Aliquam mattis eget libero non porta.
             Maecenas mollis sollicitudin felis at imperdiet. Duis dignissim purus quis interdum mattis. Nam sit amet quam quis enim hendrerit tincidunt. Aliquam euismod metus justo, non lobortis risus vehicula in. Pellentesque tempus, leo at placerat interdum, diam lectus gravida purus, id placerat justo quam nec mauris. Ut ullamcorper commodo dui in pretium. Suspendisse luctus mauris lacinia neque faucibus sollicitudin. Pellentesque ut ipsum metus. Quisque rutrum, risus eget feugiat vestibulum, enim nisl ornare risus, sit amet interdum arcu lacus at turpis. Mauris nec tristique massa. Curabitur diam urna, dapibus eget lorem porta, venenatis mattis justo. Sed eleifend accumsan lectus, id tempor metus semper in.";
             """;
        // ReSharper restore StringLiteralTypo
    }
}
