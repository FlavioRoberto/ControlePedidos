﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ControlePedido.IntegrationTests.Features.Pedido
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PedidoFeature : object, Xunit.IClassFixture<PedidoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Pedido.feature"
#line hidden
        
        public PedidoFeature(PedidoFeature.FixtureData fixtureData, ControlePedido_IntegrationTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Features/Pedido", "Pedido", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve cadastrar um pedido vinculado ao cliente com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve cadastrar um pedido vinculado ao cliente com sucesso")]
        public void DeveCadastrarUmPedidoVinculadoAoClienteComSucesso()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve cadastrar um pedido vinculado ao cliente com sucesso", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 2
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
    testRunner.Given("que eu iforme o cpf do cliente \"71935710010\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 4
    testRunner.And("que eu adicione o produto de valor 30", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 5
    testRunner.And("que eu adicione o produto de valor 20", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 6
    testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
    testRunner.Then("o status code deve ser 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 8
    testRunner.And("os dados do pedido estejam validos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
    testRunner.And("o cpf vinculado no pedido deve ser \"71935710010\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
    testRunner.And("o valor do pedido deve ser 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
    testRunner.And("o status do pedido deve ser \"Criado\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
    testRunner.And("os dados do pagamento devem estar vazios", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve cadastrar um pedidos sem vincular cliente com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve cadastrar um pedidos sem vincular cliente com sucesso")]
        public void DeveCadastrarUmPedidosSemVincularClienteComSucesso()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve cadastrar um pedidos sem vincular cliente com sucesso", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
    testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
    testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
    testRunner.Then("o status code deve ser 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
    testRunner.And("os dados do pedido estejam validos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
    testRunner.And("o cpf vinculado no pedido deve ser \"CPF não fornecido\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
    testRunner.And("o valor do pedido deve ser 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.And("o status do pedido deve ser \"Criado\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
    testRunner.And("os dados do pagamento devem estar vazios", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve exibir erro quando iniciar o preparado do pedido sem pagar")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve exibir erro quando iniciar o preparado do pedido sem pagar")]
        public void DeveExibirErroQuandoIniciarOPreparadoDoPedidoSemPagar()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve exibir erro quando iniciar o preparado do pedido sem pagar", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
    testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
    testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
    testRunner.And("eu fizer uma requisicao para iniciar o preparo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
    testRunner.Then("deve ser exibida a mensagem de erro \"Não foi realizado o pagamento para o pedido " +
                        "informado!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve iniciar o preparado do pedido quando o pagamento for realizado")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve iniciar o preparado do pedido quando o pagamento for realizado")]
        public void DeveIniciarOPreparadoDoPedidoQuandoOPagamentoForRealizado()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve iniciar o preparado do pedido quando o pagamento for realizado", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
     testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
     testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
     testRunner.And("eu fizer o pagamento manual do pedido criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
     testRunner.And("eu fizer uma requisicao para iniciar o preparo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
     testRunner.Then("o cpf vinculado no pedido deve ser \"CPF não fornecido\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
     testRunner.And("o status do pedido deve ser \"Em preparacao\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
     testRunner.And("os dados do pagamento devem estar preenchidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve exibir erro quando finalizar o preparado do pedido sem ter iniciado")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve exibir erro quando finalizar o preparado do pedido sem ter iniciado")]
        public void DeveExibirErroQuandoFinalizarOPreparadoDoPedidoSemTerIniciado()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve exibir erro quando finalizar o preparado do pedido sem ter iniciado", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
    testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
    testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
    testRunner.And("eu fizer uma requisicao para finalizar o prepado do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
    testRunner.Then("deve ser exibida a mensagem de erro \"Não foi possível finalizar o preparo do pedi" +
                        "do pois o preparo não foi iniciado!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve finalizar o preparado do pedido quando o pedido já foi iniciado")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve finalizar o preparado do pedido quando o pedido já foi iniciado")]
        public void DeveFinalizarOPreparadoDoPedidoQuandoOPedidoJaFoiIniciado()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve finalizar o preparado do pedido quando o pedido já foi iniciado", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 46
     testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 47
     testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
     testRunner.And("eu fizer o pagamento manual do pedido criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
     testRunner.And("eu fizer uma requisicao para iniciar o preparo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
     testRunner.And("eu fizer uma requisicao para finalizar o prepado do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
     testRunner.Then("o cpf vinculado no pedido deve ser \"CPF não fornecido\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
     testRunner.And("o status do pedido deve ser \"Pronto\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
     testRunner.And("os dados do pagamento devem estar preenchidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve exibir erro quando for feita a entrega do pedido sem finalizar o preparo")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve exibir erro quando for feita a entrega do pedido sem finalizar o preparo")]
        public void DeveExibirErroQuandoForFeitaAEntregaDoPedidoSemFinalizarOPreparo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve exibir erro quando for feita a entrega do pedido sem finalizar o preparo", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 55
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 56
    testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 57
    testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
    testRunner.And("eu fizer uma requisicao para realizar a entrega do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
    testRunner.Then("deve ser exibida a mensagem de erro \"Não foi possível finalizar o pedido pois o p" +
                        "reparo não foi finalizado!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve realizar a entrega do pedido quando o pedido já foi finalizado")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve realizar a entrega do pedido quando o pedido já foi finalizado")]
        public void DeveRealizarAEntregaDoPedidoQuandoOPedidoJaFoiFinalizado()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve realizar a entrega do pedido quando o pedido já foi finalizado", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 61
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 62
     testRunner.Given("que eu adicione o produto de valor 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 63
     testRunner.When("eu fizer uma requisicao para gerar o pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
     testRunner.And("eu fizer o pagamento manual do pedido criado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
     testRunner.And("eu fizer uma requisicao para iniciar o preparo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
     testRunner.And("eu fizer uma requisicao para finalizar o prepado do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
     testRunner.And("eu fizer uma requisicao para realizar a entrega do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
     testRunner.Then("o cpf vinculado no pedido deve ser \"CPF não fornecido\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
     testRunner.And("o status do pedido deve ser \"Finalizado\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
     testRunner.And("os dados do pagamento devem estar preenchidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deve listar os pedidos")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "Deve listar os pedidos")]
        public void DeveListarOsPedidos()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deve listar os pedidos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 72
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 73
     testRunner.Given("que eu tenha pedidos cadastrados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 74
     testRunner.When("eu fizer uma requisicao listar os pedidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
     testRunner.Then("deve ser exibida a lista dos pedidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PedidoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PedidoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion