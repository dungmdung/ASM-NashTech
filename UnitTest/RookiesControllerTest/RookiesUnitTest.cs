using Assignment7.Controllers;
using Assignment7.Models;
using Assignment7.Services;
using Moq;
using NUnit.Framework;

namespace RookiesUnitTest;

public class Tests
{
    private RookiesController _rookiesController;
    private Mock<IPersonService> _personService;

    [SetUp]
    public void Setup()
    {
        _personService = new Mock<IPersonService>();
        _rookiesController = new RookiesController(_personService.Object);
    }

    [Test]
    public void AddPerson_Success()
    {
        var mockModel = new MembersCreateModel
        {
            FirstName = "Dung",
            LastName = "Do",
            Gender = "Male",
            DateOfBirth = new DateTime(2001, 8, 21),
            PhoneNumber = "1414234123",
            BirthPlace = "Ha Noi"
        };
        var result = _rookiesController.Create(mockModel);

        Assert.IsInstanceOf<RedirectToActionResult>(result);

        Assert.AreEqual((result as RedirectToActionResult).ActionName, "Index");
    }

    [Test]
    public void Details_ReturnsToAction_InvalidIndex()
    {
        _personService.Setup(p => p.GetOne(It.IsAny<int>())).Returns(null as MembersModel);
        var index = 0;

        var result = _rookiesController.Detail(index);

        Assert.IsInstanceOf<RedirectToActionResult>(result);

        Assert.AreEqual((result as RedirectToActionResult).ActionName, "Index");
    }

    [Test]
    public void Details_ReturnsView_ValidIndex()
    {
        var expectModel = new MembersModel
        {
            FirstName = "Dung",
            LastName = "Do"
        };
        _personService.Setup(p => p.GetOne(It.IsAny<int>())).Returns(expectModel);
        var index = 0;

        var result = _rookiesController.Detail(index);

        Assert.IsNotNull(result);

        var returnModel = result.Models as MembersModel;

        Assert.AreEqual(expectModel.FirstName, returnModel.FirstName);

        Assert.AreEqual(expectModel.LastName, returnModel.LastName);
    }

    [Test]
    public void DeleteAndRedirectToResultView_InvalidIndex()
    {
        _personService.Setup(p => p.Delete(It.IsAny<int>())).Returns(null as MembersModel);

        var index = 0;

        var result = _rookiesController.DeleteAndRedirectToResultView(index);

        Assert.That(result, Is.InstanceOf<RedirectToActionResult>());

        Assert.That(((RedirectToActionResult)result).ActionName, Is.EqualTo("Index"));
    }
}