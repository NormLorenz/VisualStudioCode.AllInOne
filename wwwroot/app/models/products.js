var attr = DS.attr;
var hasMany = DS.hasMany;
var belongsTo = DS.belongsTo;

app.Product = DS.Model.extend({
  name: attr('string'),
  category: attr('string'),
  price: attr('number'),
  
  formattedPrice: function () {
  var price = this.get('price'),
    formatted = parseFloat(price, 10).toFixed(2);
  return '$' + formatted;
  }.property('price')
  
});
