﻿namespace PublisherService.DataModels;

public class SantanderDataModel
{
	public Guid Id { get; } = Guid.NewGuid();
	public string Customer { get; }
	public double Cash { get; }
	public string Part { get; }

	public SantanderDataModel(string customer, double cash, string part)
	{
		Customer = customer;
		Cash = cash;
		Part = part;
	}
}
