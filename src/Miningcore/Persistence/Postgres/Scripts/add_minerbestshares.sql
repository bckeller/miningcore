SET ROLE miningcore;

CREATE TABLE IF NOT EXISTS minerbestshares
(
	poolid TEXT NOT NULL,
	miner TEXT NOT NULL,
	worker TEXT NOT NULL,
	difficulty DOUBLE PRECISION NOT NULL,
	created TIMESTAMPTZ NOT NULL,

	primary key(poolid, miner, worker)
);
