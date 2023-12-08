## Ćwiczenie 1: kalkulator podatkowy (progresywny)

1. Utwórz kalkulator podatkowy (progresywny) na podstawie następujących wymagań:
- **I próg podatkowy** do 30 000 zł podatek wynosi 0% dochodu.
- **II próg podatkowy** obowiązuje dla dochodu do 120 000 zł. Wysokość należności wynosi 12% dochodu.
- **III próg podatkowy** obowiązuje po przekroczeniu kwoty 120 000 zł. Wysokość należności wynosi 32% dochodu.

na podst.
https://www.pit.pl/aktualnosci/przekroczenie-i-progu-podatkowego-a-rozliczenie-podatkowe-za-2023-rok-1009062


Przykład:
~~~ csharp
public class ProgressiveTaxCalculator
{
    public decimal CalculateTax(decimal income)
    {
        throw new NotImplementedException();
    }
}
~~~

2. Utwórz testy jednostkowe do powyższego kalkulatora.

---

Przykład:
120 000 zł - 30 000 zł = 90 000 zł * 12% = 10 800 zł
150 000 zł - 120 000 zł = 30 000 zł * 32% = 9 600 zł