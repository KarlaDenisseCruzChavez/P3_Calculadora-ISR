using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.Test;

public class ISRShould
{
    [Fact]
    public void ProcessISR_WhenIndexThan0_01_AndIndexLessThan7735()
    {
        var expectedISR = 95.99980799999999;
        var salario = new Salario { SalarioO = 5000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan7735_01_AndIndexLessThan65651_07()
    {
        var expectedISR = 517.46936;
        var salario = new Salario { SalarioO = 13500 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    
    [Fact]
    public void ProcessISR_WhenIndexThan65651_08_AndIndexLessThan115375_90()
    {
        var expectedISR = 4328.302495999999;
        var salario = new Salario { SalarioO = 70000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan115375_91_AndIndexLessThan134119_41()
    {
        var expectedISR = 9265.2;
        var salario = new Salario { SalarioO = 120000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan134119_42_AndIndexLessThan160577_65()
    {
        var expectedISR = 15109.959935999997 ;
        var salario = new Salario { SalarioO = 150000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan160577_66_AndIndexLessThan323862()
    {
        var expectedISR =  25426.081824  ;
        var salario = new Salario { SalarioO = 200000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    
    [Fact]
    public void ProcessISR_WhenIndexThan323862_01_AndIndexLessThan510451()
    {
        var expectedISR =   69790.665248;
        var salario = new Salario { SalarioO = 400000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan510451_01_AndIndexLessThan974535_03()
    {
        var expectedISR = 95768.74;
        var salario = new Salario { SalarioO = 700000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan974535_04_AndIndexLessThan1299380_04()
    {
        var expectedISR =  234993.95;
        var salario = new Salario { SalarioO = 1000000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan1299380_05_AndIndexLessThan3898140_12()
    {
        var expectedISR =  338944.34 ;
        var salario = new Salario { SalarioO = 2000000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexThan3898140_13()
    {
        var expectedISR =  1222522.76  ;
        var salario = new Salario { SalarioO = 5000000 };
        var sut = new ISRServices();

        var result = sut.ProcessISR(salario);
        Assert.Equal(expectedISR, result.index);
    }
}