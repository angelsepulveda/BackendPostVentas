using System.Xml.Linq;

namespace WareHouse.Applcation.WareHouse.UnitTests.Brands
{
    public class CreateBrandCommandHandlerTests
    {

        private readonly Mock<IBrandRepository> _mockBrandRepository;
        private readonly Mock<IUnitOfWork> _mockUnitOfWock;
        private readonly CreateBrandCommandHandler _handler;

        public CreateBrandCommandHandlerTests()
        {
            _mockBrandRepository = new Mock<IBrandRepository>();
            _mockUnitOfWock = new Mock<IUnitOfWork>();

            _handler = new CreateBrandCommandHandler(_mockBrandRepository.Object,_mockUnitOfWock.Object);
        }


        [Fact]
        public async Task Handle_Should_AddBrandAndSaveChanges()
        {
            // Arrange

            var command = new CreateBrandCommand("Test Brand",
                "Test Description");  

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            _mockBrandRepository.Verify(mock => mock.Add(It.IsAny<Brand>()), Times.Once);
            _mockUnitOfWock.Verify(mock => mock.SaveChangesAsync(CancellationToken.None), Times.Once);

        }  
    }
}
