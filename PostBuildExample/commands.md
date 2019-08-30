## Commands for the article

> copy "$(SolutionDir)\Files\customers.csv" "$(TargetDir)\customers.csv"

> if $(ConfigurationName) == Debug copy "$(SolutionDir)\Files\customers.csv" "$(TargetDir)\customers.csv"
> if $(ConfigurationName) == Release copy "$(SolutionDir)\Files\customers.csv" "$(TargetDir)\customers.csv"


```vb
if $(ConfigurationName) == Debug (
  echo "do copy".
) ELSE (
  echo "no copy".
)
```