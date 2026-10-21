

using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace FormsUITestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            
                         using (var app = Application.Launch(@"C:\Development\WinFormUITest\WinFormsUITesting\WinFormsUITesting\bin\Debug\net8.0-windows\WinFormsUITesting.exe"))
                        {
                            using (var automation = new UIA3Automation())
                            {

                                Window window = app.GetMainWindow(automation) ?? throw new InvalidOperationException("Main window not found");
                                (window.FindFirstDescendant(cf =>
                                    cf.ByAutomationId("btnChangeMessage"))
                                    ?.AsButton() ?? throw new InvalidOperationException("Button not found"))
                                    .Invoke();
                                Label label = window.FindFirstDescendant(cf =>
                                    cf.ByAutomationId("lblMessage"))
                                    ?.AsLabel() ?? throw new InvalidOperationException("Label not found");

                                Assert.That("Hello World" == label.Text);
                                app.Close();
                            }
                        }
            
            //Assert.Pass("pass");
        }
    }
}