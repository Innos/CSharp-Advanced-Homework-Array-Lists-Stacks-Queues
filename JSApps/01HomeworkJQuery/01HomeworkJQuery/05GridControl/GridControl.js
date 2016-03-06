$.prototype.grid = function () {

    this.addRow = function (params) {
        var row = $("<tr>");

        $.each(params,function (index) {
            var item = $("<td>");
            item.text(params[index]);
            row.append(item);
        });

        this.find("tbody").append(row);
        return this;
    };

    this.addHeader = function (params) {
        var row = $("<tr>");

        $.each(params,function (index) {
            var item = $("<th>");
            item.text(params[index]);
            row.append(item);
        });

        this.find("thead").empty().append(row);
        return this;
    };


    var thead = $("<thead>");
    var tbody = $("<tbody>");
    this.append(thead).append(tbody);
    return this;
};

var grid = $("#myGrid")
    .grid()
    .addHeader(['First Name', 'Last Name', 'Age'])
    .addRow(['Bay', 'Ivan', 50])
    .addRow(['Kaka', 'Penka', 26]);

    grid.addHeader(['Column1','Column2','Column3']);



