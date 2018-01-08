# Iso8601Duration - C# Library

<img src="https://docs.microsoft.com/es-es/dotnet/images/hub/csharp.svg" alt="C#" width="150" height="150" />

ISO 8601 :: C# library to convert a duration pattern in a TimeSpan object and vice versa.

You can find more information about the ISO 8601 and the lexical reprentation in the next link.
[ISO 8601 - Lexical Representation - Duration](https://www.w3.org/TR/xmlschema-2/#duration)

The format of a lexical representation is:
> PnYnMnDTnHnMnS



## List of the Library Structs

- [x] [`DurationStruct`](#durationstruct)


### `DurationStruct`

![Separator](/images/bullet_green.png) **`struct DurationStruct`** - Struct to work with dates and times easily.

```csharp
public int Years;
public int Months;
public int Days;
public int Hours;
public int Minutes;
public int Seconds;

```



## List of the Library Method's

- [x] [`NormalizeDuration`](#normalizeduration)
- [x] [`ToDurationStruct`](#todurationstruct)
- [x] [`ToString`](#tostring)
- [x] [`ToTimeSpan`](#totimespan)


### `NormalizeDuration`

![Separator](/images/bullet_green.png) **`string NormalizeDuration(string pattern)`** - Converts a general pattern in a correct and a well formed pattern.

```csharp
// "PT61S" to "PT1M1S"
var periodBuilder = new PeriodBuilder();
var pattern = "PT61S";
var wellFormedPattern = periodBuilder.NormalizeDuration(inputPattern);

```


### `ToDurationStruct`

![Separator](/images/bullet_green.png) **`DurationStruct ToDurationStruct(TimeSpan timeSpan)`** - Converts from TimeSpan to DurationStruct.

```csharp
var periodBuilder = new PeriodBuilder();
var durationStruct = periodBuilder.ToDurationStruct(new TimeSpan(0, 0, 120));

```

![Separator](/images/bullet_green.png) **`DurationStruct ToDurationStruct(string pattern)`** - Converts from TimeSpan to DurationStruct.

```csharp
var periodBuilder = new PeriodBuilder();
var durationStruct = periodBuilder.ToDurationStruct("P1Y");

```


### `ToString`

![Separator](/images/bullet_green.png) **`string ToString(TimeSpan timeSpan)`** - Converts from TimeSpan to Duration Pattern.

```csharp
var periodBuilder = new PeriodBuilder();
var durationStruct = periodBuilder.ToString(new TimeSpan(0, 120, 0));

```

![Separator](/images/bullet_green.png) **`string ToString(DurationStruct durationStruct)`** - Converts from DurationStruct to Duration Pattern.

```csharp
var periodBuilder = new PeriodBuilder();
var durationStruct = periodBuilder.ToString("PT2H");

```


### `ToTimeSpan`

![Separator](/images/bullet_green.png) **`TimeSpan ToTimeSpan(string pattern)`** - Converts from Duration Pattern to TimeSpan.

```csharp
var periodBuilder = new PeriodBuilder();
var durationStruct = periodBuilder.ToTimeSpan("PT2H");

```

![Separator](/images/bullet_green.png) **`TimeSpan ToTimeSpan(DurationStruct durationStruct)`** - Converts from DurationStruct to TimeSpan.

```csharp
var periodBuilder = new PeriodBuilder();
var durationStruct = periodBuilder.ToTimeSpan(new DurationStruct() { Minutes = 1440 });

```
