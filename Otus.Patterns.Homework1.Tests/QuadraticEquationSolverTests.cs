using FluentAssertions;

namespace Otus.Patterns.Homework1.Tests
{
    public class QuadraticEquationSolverTests
    {
        [Test]
        public void Solve_InsertAeq1Beq0Ceq1_NoQuadraticRoots()
        {
            // arrange
            var a = 1.0;
            var b = 0.0;
            var c = 1.0;

            var solver = new QuadraticEquationSolver();

            // act
            var actualRoots = solver.Solve(a, b, c);

            // assert
            actualRoots.Should().BeEmpty();
        }
    }
}