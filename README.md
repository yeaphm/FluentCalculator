# Fluent Calculator

This project implements a simple calculator with a fluent syntax using C# console application. The calculator follows specific rules and constraints to ensure its functionality and maintain consistency.

## Usage

Instantiate the `FluentCalculator` object to begin calculations. The calculator allows chaining of values and operations in a fluent manner.

```csharp
var calculator = new FluentCalculator();
```

Values in the calculator range from zero to ten and are represented by their respective words (`one`, `two`, ..., `ten`). Supported operations include `plus`, `minus`, `times`, and `dividedBy`.

## Example Usage

```csharp
var result = calculator.one.plus.two.plus.three.minus.one.minus.two.minus.four;
Console.WriteLine(result); // Output: -1

result = calculator.one.plus.ten - 10;
Console.WriteLine(result); // Output: 1
```

## Rules and Constraints

- **Separation of Values and Operations:** Values and operations are separated into two distinct entities. A value can call an operation, but cannot call another value, and vice versa.
- **Stackable to Infinity:** Pairs of value and operation can be stacked infinitely to perform complex calculations.
- **Resolving Values:** Each value resolves to a primitive integer to maintain accuracy in calculations.

## Error Handling

Invalid sequences or operations that violate the defined rules will result in errors or undefined behavior. Care should be taken to adhere to the specified syntax and constraints.

## Contributions

Contributions to improve the functionality, efficiency, or usability of the Fluent Calculator are welcome. Please submit pull requests or open issues for any suggestions, bug reports, or feature requests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
