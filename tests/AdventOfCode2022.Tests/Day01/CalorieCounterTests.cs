using AdventOfCode2022.Day01;
using AdventOfCode2022.Day01.Interfaces;
using AdventOfCode2022.Day01.Models;
using Moq;
using Shouldly;

namespace AdventOfCode2022.Tests.Day01;

public class CalorieCounterTests {

    private readonly Mock<ICaloriesReader> _mockReader = new();
    
    [Fact]
    public async Task GetMostCalories_SeveralItems_ReturnsMostCalories() {
        var expectedList = new List<Calories>(new Calories[] {
                new Calories(new int[] {100, 200, 200}),
                new Calories(new int[] {500, 500})
            });
        _mockReader.Setup(m => m.ReadCaloryList()).ReturnsAsync(expectedList);

        var calorieCounter = new CalorieCounter(_mockReader.Object);
        var mostCalories = await calorieCounter.GetMostCalories();

        _mockReader.Verify(m => m.ReadCaloryList(), Times.Once);
        mostCalories.ShouldBe(1000);
    }
}