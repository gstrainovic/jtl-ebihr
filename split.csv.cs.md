    public static void SplitCSV(string fileName)
    {
        // Split this CSV files in multiple CSV files of 100 rows each.

        // Read the CSV file.
        using (var reader = new StreamReader(fileName))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<CatalogHardPartsSource>();

            // Split the records into chunks of 10000.
            var chunks = records.Chunk(10000);

            // Write each chunk into a new CSV file.
            int index = 0;
            foreach (var chunk in chunks)
            {
                using (var writer = new StreamWriter($"{fileName}_{index}.csv"))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(chunk);
                }
                index++;
            }
        }
    }
