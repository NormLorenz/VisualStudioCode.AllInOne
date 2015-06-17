app.TableRoute = Ember.Route.extend({
	model: function () {
		return this.store.findAll('product');	
	}
});
